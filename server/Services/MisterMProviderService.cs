using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using MisterM.Utilities;
using Path = System.IO.Path;

namespace MisterM.Services
{
    public class MisterMProviderService
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;

        private readonly string _misterMBinaryPath;
        public string X64Bin { get; private set; } = "MisterM_x64";
        public string X86Bin { get; private set; } = "MisterM_x86";
        private string _defaultFileExtension;

        public MisterMProviderService(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;
            _misterMBinaryPath = Path.Combine(_env.WebRootPath, "assets", "bin");
            _defaultFileExtension = _configuration.GetSection("Binary").GetSection("DefaultExtension").Value;
            DownloadMisterMBinary();
        }

        private void DownloadMisterMBinary()
        {
            Directory.CreateDirectory(_misterMBinaryPath);

            X64Bin = Path.ChangeExtension(X64Bin, _defaultFileExtension);
            X86Bin = Path.ChangeExtension(X86Bin, _defaultFileExtension);

            string bin64Path = Path.Combine(_misterMBinaryPath, X64Bin);
            string bin86Path = Path.Combine(_misterMBinaryPath, X86Bin);

            if (File.Exists(bin64Path) && File.Exists(bin86Path)) return;

            using (var client = new WebClient())
            {
                Uri mistermBin64Address =
                    new Uri(_configuration.GetSection("Binary").GetSection("URL").GetSection("MisterM_x64").Value);

                Uri mistermBin86Address =
                    new Uri(_configuration.GetSection("Binary").GetSection("URL").GetSection("MisterM_x86").Value);

                byte[] x64Data = client.DownloadData(mistermBin64Address);
                byte[] x86Data = client.DownloadData(mistermBin86Address);

                string createdx64Bin = Path.GetFileName(CreateFile(X64Bin, x64Data, client.ResponseHeaders));
                string createdx86Bin = Path.GetFileName(CreateFile(X86Bin, x86Data, client.ResponseHeaders));

                X64Bin = ConfigExtensionToDownloaded(createdx64Bin, X64Bin);
                X86Bin = ConfigExtensionToDownloaded(createdx86Bin, X86Bin);
            }
        }

        private string ConfigExtensionToDownloaded(string downloadedFileName, string configuredFileName)
        {
            if (downloadedFileName != configuredFileName)
            {
                string extension = Path.GetExtension(downloadedFileName);
                _configuration.GetSection("Binary").GetSection("DefaultExtension").Value =
                    extension;
                SettingsHelpers.AddOrUpdateAppSetting("Binary:DefaultExtension", extension);
                _defaultFileExtension = extension;
            }

            return downloadedFileName;
        }

        private string CreateFile(string fileName, byte[] fileData, WebHeaderCollection? headers)
        {
            if (headers != null && headers.AllKeys.Any(s => s == "Content-Disposition"))
            {
                var header = new ContentDisposition(headers["Content-Disposition"]!);

                if (Path.HasExtension(header.FileName))
                {
                    string extension = Path.GetExtension(header.FileName);
                    fileName = Path.ChangeExtension(fileName, extension);
                }
            }

            string binaryPath = Path.Join(_misterMBinaryPath, fileName);
            File.WriteAllBytes(binaryPath, fileData);

            return binaryPath;
        }

        public FileStream GetFileStream(bool bit64 = false)
        {
            // TODO: Check if path is a file (currently downloads even if resource URL is not a file
            string binPath =
                bit64 ? Path.Combine(_misterMBinaryPath, X64Bin) : Path.Combine(_misterMBinaryPath, X86Bin);

            if (!File.Exists(binPath))
            {
                DownloadMisterMBinary();
            }

            return File.OpenRead(binPath);
        }
    }
}