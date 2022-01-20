using System.Collections.Generic;

namespace MisterM.Structures
{
    public abstract record Memory<T>
    {
        public string Name { get; set; } = "Generic Memory";
        public T Used { get; set; } 
        public T Total { get; set; } 
    };

    public record RAM : Memory<float>;

    public record Storage : Memory<long>;

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