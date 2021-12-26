using Hepsiorada.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hepsiorada.Pages
{
    public partial class Cart : Form
    {
        private Customer customer;
        private double _totalPrice;
        private double totalPrice { get { return _totalPrice; } set { _totalPrice = value; totalPriceLabel.Text = value.ToString()+"$"; } }
        public Cart(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            loadCartItems();
            buyButton.Enabled = customer.userId != 0 && customer.cartItems.Count > 0;
        }

        private void loadCartItems()
        {
            cartList.Rows.Clear();
            totalPrice = 0;
            foreach(CartProductDetail product in customer.cartItems)
            {
                cartList.Rows.Add(product.id, product.name, product.description, product.price, product.tax, product.totalPriceWTax, product.stock, product.image, product.quantity);
                totalPrice += product.totalPrice;
            }
        }

        private void cartList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 9 || e.ColumnIndex == 10) && e.RowIndex >= 0)
            {
                Boolean isRemove = e.ColumnIndex == 9 ? true : false;
                int quantity = Convert.ToInt32(cartList.Rows[e.RowIndex].Cells[8].Value.ToString()) + (isRemove ? -1 : 1);
                Product product = customer.cartItems.Find(x => x.id == Convert.ToInt32(cartList.Rows[e.RowIndex].Cells[0].Value));
                CartProductDetail triggeredItem = new CartProductDetail()
                {
                    id = product.id,
                    name = product.name,
                    description = product.description,
                    image = product.image,
                    price = product.price,
                    tax = product.tax,
                    totalPriceWTax = product.totalPriceWTax,
                    stock = product.stock,
                    quantity = quantity
                };
                if (quantity <= product.stock)
                {
                cartList.Rows[e.RowIndex].Cells[8].Value = int.Parse((quantity).ToString());
                customer.triggeredCartItem(triggeredItem, isRemove);
                totalPrice += (isRemove ? -1 : 1) * product.totalPriceWTax;
                loadCartItems();
                }
                else
                    MessageBox.Show("Stock is not enough.");

            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            PaymentPage paymentPage = new PaymentPage(customer, totalPrice);
            this.Hide();
            paymentPage.ShowDialog();
            if (paymentPage.isOkay)
            {
                DataBase db = new DataBase();
                foreach (CartProductDetail cartProduct in customer.cartItems)
                    db.cartProductRemove(cartProduct.id, customer.userId);
                customer.cartItems = db.GetCartItemsWithUserId(customer.userId);
                this.Close();
            }
            else
                this.Show();
        }
    }
}
