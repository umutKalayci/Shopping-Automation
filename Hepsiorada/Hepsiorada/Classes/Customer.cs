using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace Hepsiorada.Classes
{
    public class Customer
    {
        public int userId;
        public string userName;
        public string userPassword;
        public string name;
        public Boolean isAdmin;
        public Address address;
        public List<CartProductDetail> cartItems;
        public List<Order> orders;

        public Customer()
        {
            address = new Address();
            cartItems = new List<CartProductDetail>();
            orders = new List<Order>();
        }
        public void triggeredCartItem(CartProductDetail item, Boolean isRemove)
        {
            DataBase db = new DataBase();
            if(userId != 0)
                db.cartProductUpdate(item, userId, isRemove);
            CartProductDetail cartItem = cartItems.Find(x => x.id == item.id);
            if (item.quantity == 0)
            {
                cartItems.Remove(cartItem);
            }
            else if (cartItem != null)
                cartItem.quantity = item.quantity;
            else
                cartItems.Add(item);
        }
        public void logOut()
        {
            userName = userPassword = name = null;
            isAdmin = false;
            address = new Address();
        }
    }
}
