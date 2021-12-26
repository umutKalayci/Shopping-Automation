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

namespace Hepsiorada
{
    public partial class Register : Form
    {
        private Home_Page homePage;
        private Boolean isAdmin = false;
        public Register(Home_Page homePage)
        {
            InitializeComponent();
            this.homePage = homePage;
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            Boolean validation = ValidateTextBox(Controls);
            validation = ValidateTextBox(groupBox1.Controls);
            
            if (validation)
            {
                DataBase db = new DataBase();
                homePage.customer = new Customer() { userName = userName.Text, userPassword = userPassword.Text, name = name.Text, isAdmin = isAdmin, cartItems = homePage.customer.cartItems, address = new Address() { province = province.Text, district = district.Text, neighbourhood = neighbourhood.Text, addressDetail = addressDetail.Text } };
                if (db.Register(homePage.customer))
                {
                    MessageBox.Show("Register successful.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username have already.");
                    homePage.customer.logOut();
                }
            }else
                MessageBox.Show("Fill in the red fields.");

        }
        private Boolean ValidateTextBox(Control.ControlCollection controls)
        {
            Boolean validation = true;
            foreach (Control item in controls)
            {
                if (item is TextBox && (item.ForeColor == Color.Gray || item.ForeColor == Color.Red))
                {
                    item.ForeColor = Color.Red;
                    validation = false;
                }
            }
            return validation;
        }

        private void Register_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                isAdmin = !isAdmin;
                adminLabel.Visible = isAdmin;
                MessageBox.Show(isAdmin ? "You are admin now." : "You are not admin now.");
            }
        }



        private void userName_Enter(object sender, EventArgs e)
        {
            userName.ForeColor = Color.Black;
            if (userName.Text == "User Name")
                userName.Text = "";
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userName.Text))
            {
                userName.Text = "User Name";
                userName.ForeColor = Color.Gray;
            }
        }

        private void userPassword_Enter(object sender, EventArgs e)
        {
            userPassword.ForeColor = Color.Black;
            if (userPassword.Text == "User Password")
                userPassword.Text = "";
        }

        private void userPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userPassword.Text))
            {
                userPassword.Text = "User Password";
                userPassword.ForeColor = Color.Gray;
            }
        }

        private void name_Enter(object sender, EventArgs e)
        {
            name.ForeColor = Color.Black;
            if (name.Text == "Name")
                name.Text = "";
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text))
            {
                name.Text = "Name";
                name.ForeColor = Color.Gray;
            }
        }

        private void province_Enter(object sender, EventArgs e)
        {
            province.ForeColor = Color.Black;
            if (province.Text == "Province")
                province.Text = "";
        }

        private void province_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(province.Text))
            {
                province.Text = "Province";
                province.ForeColor = Color.Gray;
            }
        }

        private void district_Enter(object sender, EventArgs e)
        {
            district.ForeColor = Color.Black;
            if (district.Text == "District")
                district.Text = "";
        }

        private void district_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(district.Text))
            {
                district.Text = "District";
                district.ForeColor = Color.Gray;
            }
        }

        private void neighbourhood_Enter(object sender, EventArgs e)
        {
            neighbourhood.ForeColor = Color.Black;
            if (neighbourhood.Text == "Neighbourhood")
                neighbourhood.Text = "";
        }

        private void neighbourhood_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(neighbourhood.Text))
            {
                neighbourhood.Text = "Neighbourhood";
                neighbourhood.ForeColor = Color.Gray;
            }
        }

        private void addressDetail_Enter(object sender, EventArgs e)
        {
            addressDetail.ForeColor = Color.Black;
            if (addressDetail.Text == "Address Detail")
                addressDetail.Text = "";
        }

        private void addressDetail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressDetail.Text))
            {
                addressDetail.Text = "Address Detail";
                addressDetail.ForeColor = Color.Gray;
            }
        }



        private void registerButton_MouseHover(object sender, EventArgs e)
        {
            registerButton.FlatAppearance.BorderColor = Color.Tomato;
        }

        private void registerButton_MouseLeave(object sender, EventArgs e)
        {
            registerButton.FlatAppearance.BorderColor = Color.Gray;
        }
    }
}
