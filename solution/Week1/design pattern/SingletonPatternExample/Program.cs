using SingletonPatternExample.Logger;

var logger1 = Logger.GetInstance();
var logger2 = Logger.GetInstance();

logger1.Log("Application started.");
logger2.Log("Another log message.");

Console.WriteLine($"Same instance: {ReferenceEquals(logger1, logger2)}");
