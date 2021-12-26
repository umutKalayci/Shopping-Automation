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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            userListRefresh();
        }
        private void userListRefresh()
        {
            userList.Rows.Clear();
            DataBase db = new DataBase();
            List<Customer> customers = db.GetAllUsers();
            foreach (Customer customer in customers)
            {
                userList.Rows.Add(customer.userId, customer.userName, customer.name, customer.address.province, customer.isAdmin);
            }
        }
        private void userList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 5 || e.ColumnIndex == 6) && e.RowIndex >= 0)
            {
                Boolean isRemove = e.ColumnIndex == 6 ? true : false;
                int userId = Convert.ToInt32(userList.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (isRemove)
                {
                    DataBase db = new DataBase();
                    db.DeleteCustomer(userId);
                    userListRefresh();
                }
                else
                {
                    Profile profilePage = new Profile((new DataBase()).GetCustomerWithId(userId));
                    this.Hide();
                    profilePage.ShowDialog();
                    this.Show();
                }
            }
        }
    }
}
