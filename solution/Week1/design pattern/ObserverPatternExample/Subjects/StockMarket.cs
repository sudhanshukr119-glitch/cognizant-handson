using ObserverPatternExample.Observers;

namespace ObserverPatternExample.Subjects;

public interface IStock
{
    void Register(IObserver observer);
    void Deregister(IObserver observer);
    void NotifyObservers();
}

public class StockMarket : IStock
{
    private readonly List<IObserver> _observers = new();
    private string _stockName = "";
    private double _price;

    public void Register(IObserver observer) => _observers.Add(observer);
    public void Deregister(IObserver observer) => _observers.Remove(observer);
    public void NotifyObservers() => _observers.ForEach(o => o.Update(_stockName, _price));

    public void SetPrice(string stock, double price)
    {
        _stockName = stock; _price = price;
        NotifyObservers();
    }
}
