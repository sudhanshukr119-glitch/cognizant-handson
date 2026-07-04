namespace BuilderPatternExample.Models;

public class Computer
{
    public string CPU { get; }
    public string RAM { get; }
    public string Storage { get; }
    public string? GPU { get; }

    private Computer(Builder b)
    {
        CPU = b.CPU; RAM = b.RAM; Storage = b.Storage; GPU = b.GPU;
    }

    public override string ToString() =>
        $"CPU: {CPU}, RAM: {RAM}, Storage: {Storage}, GPU: {GPU ?? "None"}";

    public class Builder
    {
        public string CPU { get; }
        public string RAM { get; }
        public string Storage { get; }
        public string? GPU { get; private set; }

        public Builder(string cpu, string ram, string storage)
        {
            CPU = cpu; RAM = ram; Storage = storage;
        }

        public Builder WithGPU(string gpu) { GPU = gpu; return this; }

        public Computer Build() => new(this);
    }
}
