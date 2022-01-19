using System.Collections.Generic;

namespace MisterM.Structures
{
    public abstract record Memory
    {
        public string Name { get; set; } = "Generic Memory";
        public float Used { get; set; } = 0;
        public float Total { get; set; } = 0;
    };

    public record RAM : Memory;

    public record Storage : Memory;

    public record CPU
    {
        public string Name { get; set; } = "Generic CPU";
        public float? Temperature { get; set; }
        public float MaxTemperature { get; set; } = 90;
        public float Load { get; set; }
        public List<float> ClockSpeed { get; set; }
    }

    public record Motherboard
    {
        public string Name { get; set; } = "Generic Motherboard";
        public string ChassisType { get; set; } = "Desktop";
        public string SerialNumber { get; set; }
    }

    public struct ComputerReading
    {
        public Motherboard Motherboard { get; set; }

        // TODO: Implement custom serialization
        // public List<Memory> StorageDevices { get; set; }
        public Storage Storage { get; set; }

        public RAM Ram { get; set; }
        public CPU Cpu { get; set; }
        public string? Mac { get; set; }
    }
}