using System;
class Computer
{
    public string CPU { get; private set; }
    public string RAM { get; private set; }
    public string Storage { get; private set; }
    public string GraphicsCard { get; private set; }

    private Computer(Builder builder)
    {
        CPU = builder.CPU;
        RAM = builder.RAM;
        Storage = builder.Storage;
        GraphicsCard = builder.GraphicsCard;
    }

    public void DisplayConfig()
    {
        Console.WriteLine($"CPU: {CPU}, RAM: {RAM}, Storage: {Storage}, GraphicsCard: {GraphicsCard}");
    }

    public class Builder
    {
        public string CPU { get; private set; }
        public string RAM { get; private set; }
        public string Storage { get; private set; }
        public string GraphicsCard { get; private set; }

        public Builder SetCPU(string cpu)
        {
            CPU = cpu;
            return this;
        }

        public Builder SetRAM(string ram)
        {
            RAM = ram;
            return this;
        }

        public Builder SetStorage(string storage)
        {
            Storage = storage;
            return this;
        }

        public Builder SetGraphicsCard(string gpu)
        {
            GraphicsCard = gpu;
            return this;
        }

        public Computer Build()
        {
            return new Computer(this);
        }
    }
}

class Program
{
    static void Main()
    {
        var basicPC = new Computer.Builder()
            .SetCPU("Intel i3")
            .SetRAM("8GB")
            .SetStorage("256GB SSD")
            .Build();

        var gamingPC = new Computer.Builder()
            .SetCPU("Intel i9")
            .SetRAM("32GB")
            .SetStorage("1TB SSD")
            .SetGraphicsCard("NVIDIA RTX 4080")
            .Build();

        Console.WriteLine("🖥 Basic PC:");
        basicPC.DisplayConfig();

        Console.WriteLine("\n🎮 Gaming PC:");
        gamingPC.DisplayConfig();
    }
}
