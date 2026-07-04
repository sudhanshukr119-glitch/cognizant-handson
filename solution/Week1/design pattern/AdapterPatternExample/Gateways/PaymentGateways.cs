namespace AdapterPatternExample.Gateways;

// Target interface
public interface IPaymentProcessor
{
    void ProcessPayment(double amount);
}

// Adaptee classes with their own interfaces
public class PayPalGateway
{
    public void MakePayment(double amount) =>
        Console.WriteLine($"PayPal: Processing payment of ${amount}");
}

public class StripeGateway
{
    public void ChargeCard(double amount) =>
        Console.WriteLine($"Stripe: Charging card ${amount}");
}
