using AdapterPatternExample.Gateways;

namespace AdapterPatternExample.Adapters;

public class PayPalAdapter : IPaymentProcessor
{
    private readonly PayPalGateway _gateway = new();
    public void ProcessPayment(double amount) => _gateway.MakePayment(amount);
}

public class StripeAdapter : IPaymentProcessor
{
    private readonly StripeGateway _gateway = new();
    public void ProcessPayment(double amount) => _gateway.ChargeCard(amount);
}
