public class PaymentProcessor
{
    public void PaymentMethod(decimal amount, string method)
    {
        if (method == "CreditCard")
        {
            Console.WriteLine($"Processing {amount} via Credit Card");
        }
        else if (method == "Paypal")
        {
            Console.WriteLine($"Processing {amount} via PayPal");
        }
        // As new payment methods are added, more if-else statements are added here
    }
}