using DP_Strategy.Strategy_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy.Context_Class
{
    public class PaymentProcessor
    {
        private decimal _amount;

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
}
