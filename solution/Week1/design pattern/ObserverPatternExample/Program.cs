using ObserverPatternExample.Observers;
using ObserverPatternExample.Subjects;

var market = new StockMarket();
var mobile = new MobileApp();
var web = new WebApp();

market.Register(mobile);
market.Register(web);

market.SetPrice("AAPL", 175.50);

Console.WriteLine("\nDeregistering WebApp...");
market.Deregister(web);

market.SetPrice("GOOGL", 140.20);
