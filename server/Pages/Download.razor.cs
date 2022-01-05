using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;

namespace MisterM.Pages
{
    public partial class DownloadComponent
    {
        // https://stackoverflow.com/questions/59596338/how-to-download-in-memory-file-from-blazor-server-side
        protected async Task<IActionResult> DownloadMisterM(MouseEventArgs obj)
        {
            Console.Out.WriteLine("Clicked Download");
            return new FileStreamResult(MisterMProviderService.GetFileStream(true), "application/octet-stream");
        }
    }
}