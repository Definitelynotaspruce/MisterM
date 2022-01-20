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
            if (_context.Computers.SingleOrDefault(c => c.mac == computerReading.Mac) != null)
            {
                // Computer already exists
                return null;
            }

            Computer computer = new Computer
            {
                mac = computerReading.Mac,
                motherboard_name = computerReading.Motherboard.Name,
                chassis_type = computerReading.Motherboard.ChassisType,
                serial_number = computerReading.Motherboard.SerialNumber,
                cpu_model = computerReading.Cpu.Name,
                cpu_temperature = computerReading.Cpu.Temperature,
                cpu_max_temperature = computerReading.Cpu.MaxTemperature,
                cpu_load = computerReading.Cpu.Load,
                cpu_average_clock_speed = computerReading.Cpu.ClockSpeed.Average(),
                total_ram = computerReading.Ram.Total,
                used_ram = computerReading.Ram.Used,
                total_storage = (long) computerReading.Storage.Total,
                total_used_storage = (long) computerReading.Storage.Used
            };
            _context.Computers.Add(computer);
            _context.SaveChanges();
            OnComputerAdded(computer);

            return computer;
        }

        public Computer UpdateComputer(ComputerReading computerReading)
        {
            Computer computer = _context.Computers.Find(computerReading.Mac);
            if (computer == null) return null;

            computer.motherboard_name = computerReading.Motherboard.Name;
            computer.chassis_type = computerReading.Motherboard.ChassisType;
            computer.serial_number = computerReading.Motherboard.SerialNumber;
            computer.cpu_model = computerReading.Cpu.Name;
            computer.cpu_temperature = computerReading.Cpu.Temperature;
            computer.cpu_max_temperature = computerReading.Cpu.MaxTemperature;
            computer.cpu_load = computerReading.Cpu.Load;
            computer.cpu_average_clock_speed = computerReading.Cpu.ClockSpeed.Average();
            computer.total_ram = computerReading.Ram.Total;
            computer.used_ram = computerReading.Ram.Used;
            computer.total_storage = (long) computerReading.Storage.Total;
            computer.total_used_storage = (long) computerReading.Storage.Used;
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