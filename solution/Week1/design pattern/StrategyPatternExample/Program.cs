using StrategyPatternExample.Strategies;

var context = new PaymentContext(new CreditCardPayment());
context.ExecutePayment(150.00);

context.SetStrategy(new PayPalPayment());
context.ExecutePayment(75.50);
