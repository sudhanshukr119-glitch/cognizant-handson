namespace ObserverPatternExample.Observers;

public interface IObserver
{
    void Update(string stock, double price);
}

public class MobileApp : IObserver
{
    public void Update(string stock, double price) =>
        Console.WriteLine($"MobileApp: {stock} price updated to ${price}");
}

public class WebApp : IObserver
{
    public void Update(string stock, double price) =>
        Console.WriteLine($"WebApp: {stock} price updated to ${price}");
}
