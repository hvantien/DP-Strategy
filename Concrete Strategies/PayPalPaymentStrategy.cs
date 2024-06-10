using DP_Strategy.Strategy_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy.Concrete_Strategies
{
    public class PayPalPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing {amount} via PayPal");
        }
    }
}
