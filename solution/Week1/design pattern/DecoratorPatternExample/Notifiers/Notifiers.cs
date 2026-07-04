namespace DecoratorPatternExample.Notifiers;

public interface INotifier
{
    void Send(string message);
}

public class EmailNotifier : INotifier
{
    public void Send(string message) =>
        Console.WriteLine($"Email: {message}");
}
