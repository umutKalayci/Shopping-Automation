using Hepsiorada.Classes;
using Hepsiorada.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hepsiorada
{
    public partial class Home_Page : Form
    {
        public Customer customer =new Customer();
        public List<Product> products;
        public Home_Page()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            productListRefresh();
            //openDialog(new AdminPanel(this)); //En başta admin sayfasının açılması için

        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            openDialog(new Register(this));
            loginUICheck();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            openDialog(new Login(this));
            loginUICheck();
            refreshCart();
            productListRefresh();
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            customer.logOut();
            loginUICheck();
            MessageBox.Show("Logout successful.");
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            Profile profilePage = new Profile(customer);
            this.Hide();
            profilePage.ShowDialog();
            this.Show();
        }
        private void adminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDialog(new ProductManagement(this));
            DataBase db = new DataBase();
            customer.cartItems = db.GetCartItemsWithUserId(customer.userId);
            refreshCart();
        }
        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDialog(new UserManagement());
        }
        private void cartButton_Click(object sender, EventArgs e)
        {
            openDialog(new Cart(customer));
            productListRefresh();
            refreshCart();
        }
        private void productList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 10 || e.ColumnIndex == 11) && e.RowIndex >= 0)
            {
                Boolean isRemove = e.ColumnIndex == 10 ? true : false;
                int quantity = Convert.ToInt32(productList.Rows[e.RowIndex].Cells[9].Value.ToString());
                Product product = products.Find(x => x.id == Convert.ToInt32(productList.Rows[e.RowIndex].Cells[0].Value));
                if (isRemove && quantity == 0)
                    MessageBox.Show("It can't be less than 0");
                else
                {
                    quantity += (isRemove ? -1 : 1);
                    //MessageBox.Show("Ürün adi: "+ product.name+"\nMiktar: "+amount+"\nTotal Price:"+amount*product.price);
                    productList.Rows[e.RowIndex].Cells[9].Value = int.Parse((quantity).ToString());
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
                        cartQuantityLabel.Text = ((Convert.ToInt32(cartQuantityLabel.Text) + (isRemove ? -1 : 1))).ToString();
                        if (Convert.ToInt32(cartQuantityLabel.Text) > 9)
                            cartQuantityLabel.Text = "+9";
                        customer.triggeredCartItem(triggeredItem, isRemove);
                        refreshCart();
                    }
                    else
                    {
                        productList.Rows[e.RowIndex].Cells[9].Value = int.Parse((quantity-1).ToString());
                        MessageBox.Show("Stock is not enough.");
                    }

                }
            }
        }

        public void loginUICheck()
        {
            userManagerButton.Visible = productManagerButton.Visible = adminLabel.Visible =  customer.isAdmin;

            loginButton.Visible = registerButton.Visible = !(customer.name != null);
            profileButton.Visible = logoutButton.Visible = (customer.name != null);
        }
        public void productListRefresh()
        {
            productList.Rows.Clear();
            DataBase dbProducts = new DataBase();
            products = dbProducts.GetProductList();
            foreach (Product product in products)         
                productList.Rows.Add(product.id, product.name, product.description,product.weight, product.price, product.tax, product.totalPriceWTax, product.stock , product.image, (customer.cartItems.Find(x => x.id == product.id) != null ? customer.cartItems.Find(x => x.id == product.id).quantity : 0));
        }
        private void refreshCart()
        {
            listBox1.Items.Clear();
            int cartQuantity = 0;
            foreach(CartProductDetail order in customer.cartItems)
            {
                listBox1.Items.Add("Name: " + order.name + " Price: " + order.totalPriceWTax + " Quantity: " + order.quantity + " Total Price: " + order.totalPrice);
                cartQuantity += order.quantity;
            }
            cartQuantityLabel.Text = cartQuantity > 9 ? "+9" : cartQuantity.ToString();

        }
        private void openDialog(Form page)
        {
            this.Hide();
            page.ShowDialog();
            this.Show();
        }

        private void logoutButton_MouseEnter(object sender, EventArgs e)
        {
            logoutButton.ForeColor = Color.Tomato;
        }

        private void logoutButton_MouseLeave(object sender, EventArgs e)
        {
            logoutButton.ForeColor = Color.Black;

        }

        private void profileButton_MouseEnter(object sender, EventArgs e)
        {
            profileButton.ForeColor = Color.Tomato;
        }

        private void profileButton_MouseLeave(object sender, EventArgs e)
        {
            profileButton.ForeColor = Color.Black;
        }

        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.ForeColor = Color.Tomato;
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.ForeColor = Color.Black;
        }

        private void registerButton_MouseEnter(object sender, EventArgs e)
        {
            registerButton.ForeColor = Color.Tomato;
        }

        private void registerButton_MouseLeave(object sender, EventArgs e)
        {
            registerButton.ForeColor = Color.Black;
        }

        private void menuAllProductButton_Click(object sender, EventArgs e)
        {
            allProductsPanel.Visible = true;
            lastProductsPanel.Visible = false;
            refreshCart();
            productListRefresh();
        }
        private void menuLastProductMenu_Click_1(object sender, EventArgs e)
        {
            allProductsPanel.Visible = false;
            lastProductsPanel.Visible = true;
            if (products.Count >= 1)
            {
                lastItemPanel1.Visible = true;
                lastProductImage1.Image = products[(products.Count - 1)].image;
                lastproductName1.Text = products[(products.Count - 1)].name;
                lastProductDescription1.Text = products[(products.Count - 1)].description;
                lastProductPrice1.Text = products[(products.Count - 1)].totalPriceWTax+"$";
                if (products.Count >= 2)
                {
                    lastItemPanel2.Visible = true;
                    lastProductImage2.Image = products[(products.Count - 2)].image;
                    lastProductName2.Text = products[(products.Count - 2)].name;
                    lastProductDescription2.Text = products[(products.Count - 2)].description;
                    lastProductPrice2.Text = products[(products.Count - 2)].totalPriceWTax + "$";
                    if (products.Count >= 3)
                    {
                        lastItemPanel3.Visible = true;
                        lastProductImage3.Image = products[(products.Count - 3)].image;
                        lastProductName3.Text = products[(products.Count - 3)].name;
                        lastProductDescription3.Text = products[(products.Count - 3)].description;
                        lastProductPrice3.Text = products[(products.Count - 3)].totalPriceWTax + "$";
                    }
                    else
                        lastItemPanel3.Visible = false;

                }
                else
                {
                    lastItemPanel2.Visible = false;
                    lastItemPanel3.Visible = false;
                }
            }
            else
            {
                lastItemPanel1.Visible = false;
                lastItemPanel2.Visible = false;
                lastItemPanel3.Visible = false;
            }
        }
        private void productManagerButton_Click(object sender, EventArgs e)
        {
            openDialog(new ProductManagement(this));
            DataBase db = new DataBase();
            customer.cartItems = db.GetCartItemsWithUserId(customer.userId);
            refreshCart();
        }
        private void userManagerButton_Click(object sender, EventArgs e)
        {
            openDialog(new UserManagement());
        }


        private void lastProductButton1_Click(object sender, EventArgs e)
        {
            lastProductAddCart(1);
        }
        private void lastProductButton2_Click(object sender, EventArgs e)
        {
            lastProductAddCart(2);
        }

        private void lastProductButton3_Click(object sender, EventArgs e)
        {
            lastProductAddCart(3);
        }
        private void lastProductAddCart(int index)
        {
            int quantity = Convert.ToInt32(customer.cartItems.Find(x => x.id == products[(products.Count - index)].id)?.quantity);
            CartProductDetail triggeredItem = new CartProductDetail()
            {
                id = products[(products.Count - index)].id,
                name = products[(products.Count - index)].name,
                description = products[(products.Count - index)].description,
                image = products[(products.Count - index)].image,
                price = products[(products.Count - index)].price,
                tax = products[(products.Count - index)].tax,
                totalPriceWTax = products[(products.Count - index)].totalPriceWTax,
                stock = products[(products.Count - index)].stock,
                quantity = quantity + 1
            };
            if (triggeredItem.stock >= triggeredItem.quantity)
            {
                MessageBox.Show("Product added your cart.");
                customer.triggeredCartItem(triggeredItem, false);
                cartQuantityLabel.Text = ((Convert.ToInt32(cartQuantityLabel.Text) + 1)).ToString();
            }else
                MessageBox.Show("Stock is not enough.");
            if (Convert.ToInt32(cartQuantityLabel.Text) > 9)
                cartQuantityLabel.Text = "+9";
            refreshCart();
        }
    }
}
