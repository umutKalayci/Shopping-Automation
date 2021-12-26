using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hepsiorada.Classes;
namespace Hepsiorada.Pages
{
    public partial class ProductEdit : Form
    {
        Product product;
        public Boolean isEdited = false;
        public ProductEdit(Product product)
        {
            this.product = product;
            InitializeComponent();
            idBox.Text = product.id.ToString();
            nameBox.Text = product.name;
            descriptionBox.Text = product.description;
            descriptionLabel.Text = product.description; // Gerekli
            priceBox.Text = product.price.ToString();
            weightBox.Text = product.weight.ToString();
            taxBox.Text = product.tax.ToString();
            totalPriceBox.Text = product.totalPriceWTax.ToString();
            stockBox.Text = product.stock.ToString();
            pictureBox.Image = product.image != null ? product.image : Image.FromFile(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Resources\\noImage.png");
            
        }
        private void idBox_TextChanged(object sender, EventArgs e)
        {
            idLabel.Text = "#" + idBox.Text;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            nameLabel.Text = nameBox.Text;
        }

        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {
            descriptionLabel.Text = descriptionBox.Text;
        }
        private void imagePickerButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bm = new Bitmap(ofd.FileName);
                imageTextBox.Text = ofd.FileName;
                pictureBox.Image = bm;
            }
        }
        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        private void priceBox_KeyUp(object sender, KeyEventArgs e)
        {
            totalPriceBox.Text = (Convert.ToDouble((priceBox.Text != "") ? priceBox.Text : "0") * (100 + Convert.ToInt32((taxBox.Text != "") ? taxBox.Text : "0")) / 100).ToString();
            priceLabel.Text = totalPriceBox.Text + "$";
        }
        private void totalPriceBox_KeyUp(object sender, KeyEventArgs e)
        {
            priceBox.Text = (Convert.ToDouble((totalPriceBox.Text != "") ? totalPriceBox.Text : "0") * 100 / (100 + Convert.ToInt32((taxBox.Text != "") ? taxBox.Text : "0"))).ToString();
            priceLabel.Text = totalPriceBox.Text + "$";
        }
        private void taxBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            try
            {
                product.name = nameBox.Text;
                product.description = descriptionBox.Text;
                product.weight = Convert.ToDouble(weightBox.Text);
                product.price = Convert.ToDouble(priceBox.Text);
                product.image = pictureBox.Image != null ? pictureBox.Image : Image.FromFile(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Resources\\noImage.png");
                product.price = Convert.ToDouble(priceBox.Text);
                product.tax = Convert.ToInt32(taxBox.Text);
                product.totalPriceWTax = Convert.ToDouble(totalPriceBox.Text);
                product.stock = Convert.ToInt32(stockBox.Text);
                isEdited = true;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Fill in the all fields");
            }
        }
    }
}
