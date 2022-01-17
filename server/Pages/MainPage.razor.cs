using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components.Web;
using MisterM.Hubs;
using MisterM.Models.MsMisterM;

namespace MisterM.Pages
{
    public partial class MainPageComponent
    {
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

        protected static bool IsComputerOnline(string mac)
        {
            return ConnectedDevices.Set.Values.Any(computerVal => computerVal.mac == mac);
        }

        protected float GetAverageTemperature()
        {
            if (getComputersResult == null) return 0;
            IEnumerable<Computer> activeComputers = getComputersResult.Where(computer => IsComputerOnline(computer.mac));
            return activeComputers.Average(c => c.temperature) ?? 0;
        }

    }
}