using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components.Web;
using MisterM.Models.MsMisterM;

namespace MisterM.Pages
{
    public partial class MainPageComponent
    {
        protected void CustomComponentClick(MouseEventArgs args)
        {
            Console.WriteLine("Custom component clicked!");
        }

        protected void AddComputer(object sender, Computer newComputer)
        {
            List<Computer> computerList = getComputersResult.ToList();
            computerList.Add(newComputer);
            getComputersResult = computerList;
        }

        protected void UpdateComputer(object sender, Computer updatedComputer)
        {
            List<Computer> modifiedComputers = getComputersResult.Where(c => c.mac != updatedComputer.mac).ToList();
            modifiedComputers.Add(updatedComputer);
            getComputersResult = modifiedComputers;
        }

        protected void UpdateConnectedClients(object sender, int clientCount)
        {
            ActiveDevices = clientCount;
            Reload();
        }
    }
}