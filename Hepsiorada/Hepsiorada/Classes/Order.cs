using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hepsiorada.Classes
{
    public class Order
    {
        public int orderId;
        public int paymentId;
        public Payment payment;
        public string date;
        public string status;
        public Order()
        {
            payment = new Payment();
        }
    }
}
