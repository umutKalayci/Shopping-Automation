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
    public partial class Profile : Form
    {
        Customer customer;
        public Profile(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            userNameBox.Text = customer.userName;
            userPasswordBox.Text = customer.userPassword;
            userFullNameBox.Text = customer.name;
            provinceBox.Text = customer.address.province;
            districtBox.Text = customer.address.district;
            neighbourhoodBox.Text = customer.address.neighbourhood;
            addressDetailBox.Text = customer.address.addressDetail;

            foreach (Order order in customer.orders)
            {
                orderList.Rows.Add(order.orderId,order.date,order.status,order.payment.paymentType,order.payment.paymentAmount+"$");
            }
        }

        private void saveProfileButton_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            customer.userPassword= userPasswordBox.Text;
            customer.name = userFullNameBox.Text;
            customer.address.province = provinceBox.Text;
            customer.address.district = districtBox.Text;
            customer.address.neighbourhood = neighbourhoodBox.Text;
            customer.address.addressDetail = addressDetailBox.Text;
            db.UpdateCustomer(customer);
            MessageBox.Show("Update successful.");
        }

        private void orderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                OrderPage orderPage = new OrderPage(customer.orders.Find(x => x.orderId == Convert.ToInt32(orderList.Rows[e.RowIndex].Cells[0].Value)));
                this.Hide();
                orderPage.ShowDialog();
                this.Show();
            }
        }
    }
}
