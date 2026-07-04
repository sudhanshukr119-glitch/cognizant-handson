using BuilderPatternExample.Models;

var basicPC = new Computer.Builder("Intel i5", "8GB", "256GB SSD").Build();
var gamingPC = new Computer.Builder("Intel i9", "32GB", "1TB NVMe").WithGPU("RTX 4090").Build();

Console.WriteLine("Basic PC: " + basicPC);
Console.WriteLine("Gaming PC: " + gamingPC);
