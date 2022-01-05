using System;
using Microsoft.AspNetCore.Mvc;
using MisterM.Services;

namespace MisterM.Controllers
{
    public class DownloadController : Controller
    {
        private readonly MisterMProviderService _mProviderService;

        public DownloadController(MisterMProviderService mProviderService)
        {
            _mProviderService = mProviderService;
        }

        [HttpGet("/download/x86")]
        public FileStreamResult DownloadMisterMBinary_x86()
        {
            return new FileStreamResult(_mProviderService.GetFileStream(), "application/octet-stream")
                {FileDownloadName = _mProviderService._x86Bin};
        }
        
        [HttpGet("/download/x64")]
        public FileStreamResult DownloadMisterMBinary_x64()
        {
            return new FileStreamResult(_mProviderService.GetFileStream(true), "application/octet-stream")
                {FileDownloadName = _mProviderService._x64Bin};
        }
    }
}