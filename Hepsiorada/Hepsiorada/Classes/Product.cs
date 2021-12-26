using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace Hepsiorada.Classes
{
    public class Product
    {
        public int id;
        public string name;
        public string description;
        public double weight;
        public double price;
        public int tax;
        public double totalPriceWTax;
        public int stock;
        public Image image;
    }
}
