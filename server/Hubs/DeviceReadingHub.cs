using System;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.SignalR;
using MisterM.Structures;

namespace MisterM.Hubs
{
    public class DeviceReadingHub : Hub
    {
        public ComputerReading SetReadings(ComputerReading computerReading)
        {
            Console.Out.WriteLine(computerReading.Name, computerReading.Cpu.Name, computerReading.Cpu.Temperature, computerReading.MAC);
            return computerReading;
        }
    }
}