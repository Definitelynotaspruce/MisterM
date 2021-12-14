namespace MisterM.Structures
{
    public abstract record Memory(string Name, double Total, double Used);
    public record RAM(string Name, double Total, double Used) : Memory(Name, Total, Used);
    public record CPU
    {
        public string Name { get; set; } = "Generic CPU";
        public float Temperature { get; set; } = 0.0F;
    }

    public struct ComputerReading
    {
        public string Name { get; set; }
        public string? SerialNumber { get; set; }
        public Memory?[] StorageDevices { get; set; }
        public RAM? Ram { get; set; }
        public CPU Cpu { get; set; }
        public string? MAC { get; set; }
    }
}