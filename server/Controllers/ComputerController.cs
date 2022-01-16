using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using MisterM.Data;
using MisterM.Hubs;
using MisterM.Models.MsMisterM;
using MisterM.Structures;

namespace MisterM.Controllers
{
    public class ComputerController 
    {
        private readonly MsMisterMContext _context;
        private readonly IHubContext<DeviceReadingHub> _deviceHubContext;

        public static event EventHandler<Computer> ComputerAdded;
        
        public static event EventHandler<Computer> ComputerChanged;

        public ComputerController(MsMisterMContext context, IHubContext<DeviceReadingHub> deviceHubContext)
        {
            _context = context;
            _deviceHubContext = deviceHubContext;
        }

        public Computer CreateComputer(ComputerReading computerReading)
        {
            if (_context.Computers.SingleOrDefault(c => c.mac == computerReading.MAC) != null)
            {
                // Computer already exists
                return null;
            }
            
            Computer computer = new Computer
            {
                mac = computerReading.MAC,
                model = computerReading.Cpu.Name,
                name = computerReading.Name,
                temperature = computerReading.Cpu.Temperature
            };
            _context.Computers.Add(computer);
            _context.SaveChanges();
            OnComputerAdded(computer);
            
            return computer;
        }

        public Computer UpdateComputer(ComputerReading computerReading)
        {
            Computer? computer = _context.Computers.Find(computerReading.MAC);
            if (computer == null) return null;
            
            computer.model = computerReading.Cpu.Name;
            computer.name = computerReading.Name;
            computer.temperature = computerReading.Cpu.Temperature;
            _context.SaveChanges();
            OnComputerChanged(computer); 

            return computer;
        }
        
        public Computer CreateOrUpdateComputer(ComputerReading computerReading)
        {
            Computer? computer = UpdateComputer(computerReading);
            return computer ?? CreateComputer(computerReading);
        }

        public Task<int> GetComputerCount()
        {
            return _context.Computers.CountAsync();
        }

        public static int GetConnectedDeviceCount()
        {
            return ConnectedDevices.Set.Count;
        }

        protected virtual void OnComputerAdded(Computer newComputer)
        {
            ComputerAdded?.Invoke(this, newComputer);
        }

        protected virtual void OnComputerChanged(Computer updatedComputer)
        {
            ComputerChanged?.Invoke(this, updatedComputer);
        }
    }
}