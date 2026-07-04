using DecoratorPatternExample.Decorators;
using DecoratorPatternExample.Notifiers;

// Email only
INotifier notifier = new EmailNotifier();
notifier.Send("Hello via Email!");

Console.WriteLine();

// Email + SMS + Slack
INotifier allChannels = new SlackNotifierDecorator(new SMSNotifierDecorator(new EmailNotifier()));
allChannels.Send("Alert: System update!");
