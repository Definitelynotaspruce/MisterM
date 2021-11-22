using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.SignalR;
using MisterM.Controllers;
using MisterM.Models.MsMisterM;
using MisterM.Structures;

namespace MisterM.Hubs
{
    public class DeviceReadingHub : Hub
    {
        private readonly ComputerController _computerController;
        public readonly Dictionary<string, Computer> ConnectedDevices = new();
        public DeviceReadingHub(ComputerController computerController)
        {
            _computerController = computerController;
        }

        public async Task<ComputerReading> SetReadings(ComputerReading computerReading)
        {
            _computerController.CreateOrUpdateComputer(computerReading);
            return computerReading;
        }

        public override Task OnConnectedAsync()
        {
            ConnectedDevices.Add(Context.ConnectionId, new Computer()); 
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            ConnectedDevices.Remove(Context.ConnectionId);
            return base.OnDisconnectedAsync(exception);
        }
    }
}