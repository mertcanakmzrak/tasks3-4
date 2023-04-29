using System;


class Computer {
  
    public string ProcessorName;
    public int ProcessorSpeed;
    public int RamSize;

    public Computer(string processorName, int processorSpeed, int ramSize) {
        ProcessorName = processorName;
        ProcessorSpeed = processorSpeed;
        RamSize = ramSize;
    }

    public virtual double GetQuality() {
        return (0.1 * ProcessorSpeed) + RamSize;
    }

    public void DisplayInfo() {
        Console.WriteLine("Processor Name: {0}", ProcessorName);
        Console.WriteLine("Processor Speed: {0} MHz", ProcessorSpeed);
        Console.WriteLine("RAM Size: {0} MB", RamSize);
        Console.WriteLine("Quality: {0}", GetQuality());
    }
}

class Laptop : Computer {
    public int HardDriveSize;

    public Laptop(string processorName, int processorSpeed, int ramSize, int hardDriveSize) : base(processorName, processorSpeed, ramSize) {
        HardDriveSize = hardDriveSize;
    }

    public override double GetQuality() {
        return base.GetQuality() + (0.5 * HardDriveSize);
    }
}

class Program {
    static void Main(string[] args) {
        Computer computer = new Computer("Intel Core i5", 2400, 4096);
        computer.DisplayInfo();

        Laptop laptop = new Laptop("Intel Core i7", 2800, 8192, 512);
        laptop.DisplayInfo();
    }
}
