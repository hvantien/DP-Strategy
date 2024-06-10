using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy.Strategy_Interface
{
    public interface IPaymentStrategy
    {
        void ProcessPayment(decimal amount);
    }
}
