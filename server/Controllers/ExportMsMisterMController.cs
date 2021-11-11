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
        [HttpGet("/export/MsMisterM/computers/csv")]
        [HttpGet("/export/MsMisterM/computers/csv(fileName='{fileName}')")]
        public FileStreamResult ExportComputersToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Computers, Request.Query), fileName);
        }

        [HttpGet("/export/MsMisterM/computers/excel")]
        [HttpGet("/export/MsMisterM/computers/excel(fileName='{fileName}')")]
        public FileStreamResult ExportComputersToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Computers, Request.Query), fileName);
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
