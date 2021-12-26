using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hepsiorada.Classes
{
    public class CartProductDetail : Product
    {
        private int _quantity;
        public double totalPrice{ get; private set; }
        public int quantity
        {
            get {
                return _quantity;
            }
            set
            {
                _quantity = value;
                totalPrice = _quantity * this.totalPriceWTax;
            }
        }
        
    }
}
