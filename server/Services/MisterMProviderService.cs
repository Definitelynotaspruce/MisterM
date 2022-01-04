using System;
using System.Net;
using Microsoft.Extensions.Configuration;

namespace MisterM.Services
{
    public class MisterMProviderService
    {
        private readonly IConfiguration _configuration;
        private readonly string _misterMBinaryPath = "Downloadable/MisterM";

        public MisterMProviderService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void DownloadMisterMBinary()
        {
            using (var client = new WebClient())
            {
                client.DownloadFileAsync(new Uri(_configuration.GetSection("DownloadUrls").GetSection("MisterM").ToString()), _misterMBinaryPath);
            }
        }
    }
}