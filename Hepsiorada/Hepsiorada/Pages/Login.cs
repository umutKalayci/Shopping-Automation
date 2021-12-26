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
    public partial class Login : Form
    {
        private Home_Page homePage;
        public Login(Home_Page homePage)
        {
            InitializeComponent();
            this.homePage = homePage;
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            Register registerPage = new Register(homePage);
            this.Hide();
            registerPage.ShowDialog();
            this.Close();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            Boolean validation = true;
            foreach (Control item in Controls)
            {
                if (item is TextBox &&( item.ForeColor == Color.Gray || item.ForeColor == Color.Red))
                {
                    item.ForeColor = Color.Red;
                    validation = false;
                }
            }
            if (validation)
            {
                homePage.customer = new Customer() { userName = userName.Text, userPassword = userPassword.Text };
                if (db.Login(homePage.customer))
                    this.Close();
                else
                    MessageBox.Show("Wrong username or password.");
            }
            else
                MessageBox.Show("Fill in the red fields.");
        }

        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.ForeColor = Color.Tomato;
        }

        private void registerButton_MouseLeave(object sender, EventArgs e)
        {
            registerButton.ForeColor = Color.Black;
        }

        private void registerButton_MouseEnter(object sender, EventArgs e)
        {
            registerButton.ForeColor = Color.Tomato;
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.ForeColor = Color.Black;
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
            if (userPassword.Text == "Password")
            {
                userPassword.Text = "";
                userPassword.UseSystemPasswordChar = true;
            }
        }

        private void userPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userPassword.Text))
            {
                userPassword.Text = "Password";
                userPassword.ForeColor = Color.Gray;
            }
        }
    }
}
