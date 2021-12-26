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
    public partial class PaymentPage : Form
    {
        public Boolean isOkay = false;
        Customer customer;
        double totalPrice;
        string paymentType = "Credit";
        public PaymentPage(Customer customer, double totalPrice)
        {
            InitializeComponent();
            this.customer = customer;
            this.totalPrice = totalPrice;
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            object selectedPaymentType = null;
            Payment payment = new Payment()
            {
                paymentAmount = totalPrice,
                paymentType = paymentType
            };
            Boolean selectedPaymentValidate = false;
            switch (paymentType)
            {
                case "Credit":
                    if (creditCardNumber.Text != "Card Number" && creditExpDate.Text != "Exp Date" && creditCardCVC.Text != "CVC")
                    {
                        selectedPaymentType = new PCredit()
                        {
                            number = creditCardNumber.Text,
                            expDate = creditExpDate.Text,
                            cvc = creditCardCVC.Text
                        };
                        selectedPaymentValidate = true;
                    }
                    break;
                case "Pay at the door":
                    if (payersName.Text != "Payer's Name")
                    {
                        selectedPaymentType = new PPayDor()
                        {
                            payersName = payersName.Text,
                            paymentType = payCreditCart.Checked ? "Credit Cart" : "Cash" 
                        };
                        selectedPaymentValidate = true;
                    }
                    break;
            }
            if (selectedPaymentValidate)
            {
                db.Payment(customer, payment, selectedPaymentType);
                MessageBox.Show("Order successful.");
                customer.orders = db.GetOrdersWithUserId(customer.userId);
                isOkay = true;
                this.Close();
            }else
                MessageBox.Show("Fill in the all fields");
        }

        private void creditCardRadio_CheckedChanged(object sender, EventArgs e)
        {
            creditCardGroup.Visible = creditCardRadio.Checked;
            if (creditCardRadio.Checked)
            {
                paymentType = "Credit";
            }
        }

        private void payDoorRadio_CheckedChanged(object sender, EventArgs e)
        {
            payDoorGroup.Visible = payDoorRadio.Checked;
            paymentType = "Pay at the door";
        }

        private void payersName_Enter(object sender, EventArgs e)
        {
            payersName.ForeColor = Color.Black;
            if (payersName.Text == "Payer's Name")
                payersName.Text = "";
        }

        private void payersName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(payersName.Text))
            {
                payersName.Text = "Payer's Name";
                payersName.ForeColor = Color.Gray;
            }
        }

        private void creditCardNumber_Enter(object sender, EventArgs e)
        {
            creditCardNumber.ForeColor = Color.Black;
            if (creditCardNumber.Text == "Card Number")
                creditCardNumber.Text = "";
        }

        private void creditCardNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(payersName.Text))
            {
                creditCardNumber.Text = "Card Number";
                creditCardNumber.ForeColor = Color.Gray;
            }
        }

        private void creditExpDate_Enter(object sender, EventArgs e)
        {
            creditExpDate.ForeColor = Color.Black;
            if (creditExpDate.Text == "Exp Date")
                creditExpDate.Text = "";
        }

        private void creditExpDate_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(payersName.Text))
            {
                creditExpDate.Text = "Exp Date";
                creditExpDate.ForeColor = Color.Gray;
            }
        }

        private void creditCardCVC_Enter(object sender, EventArgs e)
        {
            creditCardCVC.ForeColor = Color.Black;
            if (creditCardCVC.Text == "CVC")
                creditCardCVC.Text = "";
        }

        private void creditCardCVC_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(creditCardCVC.Text))
            {
                creditCardCVC.Text = "CVC";
                creditCardCVC.ForeColor = Color.Gray;
            }
        }
    }
}
