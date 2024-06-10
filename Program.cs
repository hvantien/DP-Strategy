using DP_Strategy.Concrete_Strategies;
using DP_Strategy.Context_Class;

var creditCardPayment = new PaymentProcessor(new CreditCardPaymentStrategy());
creditCardPayment.ProcessPayment(100.00m);
// Output: Processing 100.00 via Credit Card

var payPalPayment = new PaymentProcessor(new PayPalPaymentStrategy());
payPalPayment.ProcessPayment(75.50m);
// Output: Processing 75.50 via PayPal
