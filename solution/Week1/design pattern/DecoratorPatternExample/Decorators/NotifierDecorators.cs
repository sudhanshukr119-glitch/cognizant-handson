using DecoratorPatternExample.Notifiers;

namespace DecoratorPatternExample.Decorators;

public abstract class NotifierDecorator : INotifier
{
    protected readonly INotifier _inner;
    protected NotifierDecorator(INotifier inner) => _inner = inner;
    public virtual void Send(string message) => _inner.Send(message);
}

public class SMSNotifierDecorator : NotifierDecorator
{
    public SMSNotifierDecorator(INotifier inner) : base(inner) { }
    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"SMS: {message}");
    }
}

public class SlackNotifierDecorator : NotifierDecorator
{
    public SlackNotifierDecorator(INotifier inner) : base(inner) { }
    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Slack: {message}");
    }
}
