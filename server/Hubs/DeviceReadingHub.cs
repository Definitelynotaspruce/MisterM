using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.SignalR;
using MisterM.Controllers;
using MisterM.Structures;

namespace MisterM.Hubs
{
    public class DeviceReadingHub : Hub
    {
        private readonly ComputerController _computerController;
        public DeviceReadingHub(ComputerController computerController)
        {
            _computerController = computerController;
        }

        public async Task<ComputerReading> SetReadings(ComputerReading computerReading)
        {
            Console.Out.WriteLine("Computer: {0}\nCPU: {1} Temperature: {2}C\nMAC: {3}", computerReading.Name, computerReading.Cpu.Name, computerReading.Cpu.Temperature, computerReading.MAC);
            _computerController.CreateOrUpdateComputer(computerReading);
            return computerReading;
        }
        
        public void Hello(string name)
        {
            Console.Out.WriteLine($"Got a greeting from {name}");
        }
    }
}