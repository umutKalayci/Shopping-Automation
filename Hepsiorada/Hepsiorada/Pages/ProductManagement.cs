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
    public partial class ProductManagement : Form
    {
        private Home_Page homePage;
        public ProductManagement(Home_Page homePage)
        {
            InitializeComponent();
            this.homePage = homePage;
        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            refreshProducts();
        }
        private void addNewProductButton_Click(object sender, EventArgs e)
        {
            editItem(new Product());
        }
        private void productList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 5 || e.ColumnIndex == 6) && e.RowIndex >= 0)
            {
                Boolean isDelete = e.ColumnIndex == 6;
                int selectedId = Convert.ToInt32(productList.Rows[e.RowIndex].Cells[0].Value.ToString());
                Product selectedProduct = homePage.products.Find(x => x.id == selectedId);
                if (isDelete)
                {
                    DataBase db = new DataBase();
                    db.DeleteProduct(selectedProduct);
                    refreshProducts();
                }
                else
                    editItem(selectedProduct);
            }
        }
        private void editItem(Product product)
        {
            Boolean isNew = product.id == 0;
            ProductEdit productEditPage = new ProductEdit(product);
            this.Hide();
            productEditPage.ShowDialog();
            this.Show();
            if (productEditPage.isEdited)
            {
                DataBase db = new DataBase();
                if (isNew)
                    db.AddProduct(product);
                else
                    db.UpdateProduct(product);
                refreshProducts();
            }
        }

        private void refreshProducts()
        {
            homePage.productListRefresh();
            productList.Rows.Clear();
            foreach (Product product in homePage.products)
                productList.Rows.Add(product.id, product.name, product.description, product.price, product.image);
        }
    }
}
