# Strategy Design Pattern

## Problem

Initially, There was only one payment method, but later the number of payment methods increased, Requiring the PaymentMethod function to use if-else to handle them.
Over time, Updated to some payment logic made the function more complex and harder to maintain.
This violates to Open/Close Principle: Every time a new type of payment is added, you have to modify that class.

## Solution 

When adding a new strategy you should add a new class. This helps to extend functionality without changing the existing code

## Class Diagram

![](Images/structure-indexed.png)

## Example

![](Images/paymentmethod.webp)

### Without Strategy Pattern

```C#
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

var paymentProcessor = new PaymentProcessor();
paymentProcessor.ProcessPayment(100.00m, "CreditCard");
paymentProcessor.ProcessPayment(75.50m, "PayPal");
```

**Problems with this approach**

- Scalability: when adding a new PaymentMethod you should add if-else, Making it to infinite growth.
- Maintainability: alter ProcessPayment function becomes increasingly complex and harder to manager.
- Open/Close principle violation: Every time a new payment method is added, you have modify the payment class, violating the non-modification rule of SOLID. 

### With Strategy Pattern

#### Strategy Interface

```C#
public interface IPaymentStrategy
{
    void ProcessPayment(decimal amount);
}
```


#### Concrete Strategies

```C#
public class CreditCardPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        // Logic to process Credit Card payment
        Console.WriteLine($"Processing {amount} via Credit Card");
    }
}

public class PayPalPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        // Logic to process PayPal payment
        Console.WriteLine($"Processing {amount} via PayPal");
    }
}
```

#### Context Class

```C#
public class PaymentProcessor
{
    private IPaymentStrategy _paymentStrategy;

    public PaymentProcessor(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void ProcessPayment(decimal amount)
    {
        _paymentStrategy.ProcessPayment(amount);
    }
}
```

#### Client

```C#
var creditCardPayment = new PaymentProcessor(new CreditCardPaymentStrategy());
creditCardPayment.ProcessPayment(100.00m); 
// Output: Processing 100.00 via Credit Card

var payPalPayment = new PaymentProcessor(new PayPalPaymentStrategy());
payPalPayment.ProcessPayment(75.50m); 
// Output: Processing 75.50 via PayPal
```

**Advance using strategy pattern**

- Ease of extension: Simply create a class that implements IPaymentStrategy interface. But not modify any existing code.
- Adherence to Open/Close principle: System need extension but need close modify. you can add new payment method without changing the existing code.
- Simplicity and Maintainability: Each payment method is encapsulated in its own class. Making system easy to understand and maintain