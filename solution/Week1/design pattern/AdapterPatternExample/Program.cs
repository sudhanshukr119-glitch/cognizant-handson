using AdapterPatternExample.Adapters;
using AdapterPatternExample.Gateways;

IPaymentProcessor[] processors = [new PayPalAdapter(), new StripeAdapter()];

foreach (var processor in processors)
    processor.ProcessPayment(99.99);
