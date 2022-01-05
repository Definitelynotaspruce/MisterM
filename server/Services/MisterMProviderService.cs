using System;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace MisterM.Services
{
    public class MisterMProviderService
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;
        
        private readonly string _misterMBinaryPath;
        private readonly string _x64Bin = "MisterM_x64.zip";
        private readonly string _x86Bin = "MisterM_x86.zip";

        public MisterMProviderService(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;
            _misterMBinaryPath = Path.Combine(_env.WebRootPath, "assets", "bin");
            DownloadMisterMBinary();
        }

        private void DownloadMisterMBinary()
        {
            Directory.CreateDirectory(_misterMBinaryPath);
            
            string bin64Path = Path.Combine(_misterMBinaryPath, _x64Bin);
            string bin86Path = Path.Combine(_misterMBinaryPath, _x86Bin);
            
            // TODO: Check file version in config, download if newer
            if (File.Exists(bin64Path) && File.Exists(bin86Path)) return;

            using (var client = new WebClient())
            {
                Uri mistermBin64Address =
                    new Uri(_configuration.GetSection("DownloadUrls").GetSection("MisterM_x64").Value);

                Uri mistermBin86Address =
                    new Uri(_configuration.GetSection("DownloadUrls").GetSection("MisterM_x86").Value);
                
                // if (mistermBinAddress == string.Empty)
                //     throw "Address is empty";
                    
                client.DownloadFileAsync(mistermBin64Address, bin64Path);
                client.DownloadFileCompleted += (sender, args) =>
                {
                    client.DownloadFileAsync(mistermBin86Address, bin86Path);
                };
            }
        }

        public FileStream GetFileStream(bool bit64)
        {
            string binPath =
                bit64 ? Path.Combine(_misterMBinaryPath, _x64Bin) : Path.Combine(_misterMBinaryPath, _x86Bin);
            
            if (!File.Exists(binPath))
            {
                // throw ApplicationException;
            }

            return File.OpenRead(binPath);
        }
    }
}