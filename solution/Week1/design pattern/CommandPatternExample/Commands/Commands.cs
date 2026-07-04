using CommandPatternExample.Devices;

namespace CommandPatternExample.Commands;

public interface ICommand
{
    void Execute();
}

public class LightOnCommand : ICommand
{
    private readonly Light _light;
    public LightOnCommand(Light light) => _light = light;
    public void Execute() => _light.TurnOn();
}

public class LightOffCommand : ICommand
{
    private readonly Light _light;
    public LightOffCommand(Light light) => _light = light;
    public void Execute() => _light.TurnOff();
}

public class RemoteControl
{
    private ICommand? _command;
    public void SetCommand(ICommand command) => _command = command;
    public void PressButton() => _command?.Execute();
}
