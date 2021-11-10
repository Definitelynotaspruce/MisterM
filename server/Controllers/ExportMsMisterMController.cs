using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MisterM.Data;

namespace MisterM
{
    public partial class ExportMsMisterMController : ExportController
    {
        private readonly MsMisterMContext context;

        public ExportMsMisterMController(MsMisterMContext context)
        {
            this.context = context;
        }
        [HttpGet("/export/MsMisterM/msmistermcomputers/csv")]
        [HttpGet("/export/MsMisterM/msmistermcomputers/csv(fileName='{fileName}')")]
        public FileStreamResult ExportMsMisterMComputersToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.MsMisterMComputers, Request.Query), fileName);
        }

        [HttpGet("/export/MsMisterM/msmistermcomputers/excel")]
        [HttpGet("/export/MsMisterM/msmistermcomputers/excel(fileName='{fileName}')")]
        public FileStreamResult ExportMsMisterMComputersToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.MsMisterMComputers, Request.Query), fileName);
        }
        [HttpGet("/export/MsMisterM/users/csv")]
        [HttpGet("/export/MsMisterM/users/csv(fileName='{fileName}')")]
        public FileStreamResult ExportUsersToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Users, Request.Query), fileName);
        }

        [HttpGet("/export/MsMisterM/users/excel")]
        [HttpGet("/export/MsMisterM/users/excel(fileName='{fileName}')")]
        public FileStreamResult ExportUsersToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Users, Request.Query), fileName);
        }
    }
}
