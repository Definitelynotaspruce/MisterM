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
            var computers = getComputersResult.ToList();
            computers.Add(newComputer);
            getComputersResult = computers;
        }

        protected void UpdateComputer(object sender, Computer updatedComputer)
        {
            var computers = getComputersResult.ToList();
            int index = computers.FindIndex(c => c.mac == updatedComputer.mac);
            if (index == -1)
                return;
            computers[index] = updatedComputer;
            getComputersResult = computers;
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