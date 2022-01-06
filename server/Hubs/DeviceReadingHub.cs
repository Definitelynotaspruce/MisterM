using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using MisterM.Controllers;
using MisterM.Models.MsMisterM;
using MisterM.Structures;

namespace MisterM.Hubs
{
    public static class ConnectedDevices
    {
        public static readonly Dictionary<string, Computer> Set = new();
    }

    public sealed class DeviceReadingHub : Hub
    {
        private readonly ComputerController _computerController;
        public static event EventHandler<int> ClientCountChanged;

        public DeviceReadingHub(ComputerController computerController)
        {
            _computerController = computerController;
        }

        public async Task<ComputerReading> SetReadings(ComputerReading computerReading)
        {
            ConnectedDevices.Set[Context.ConnectionId] = _computerController.CreateOrUpdateComputer(computerReading);
            return computerReading;
        }

        public override Task OnConnectedAsync()
        {
            ConnectedDevices.Set.Add(Context.ConnectionId, new Computer());
            ClientCountChanged?.Invoke(this, ConnectedDevices.Set.Count);

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            ConnectedDevices.Set.Remove(Context.ConnectionId);
            ClientCountChanged?.Invoke(this, ConnectedDevices.Set.Count);

            return base.OnDisconnectedAsync(exception);
        }
    }
}