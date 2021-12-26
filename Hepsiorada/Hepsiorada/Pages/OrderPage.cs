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
    public partial class OrderPage : Form
    {
        Order order;
        List<OrderDetail> orderDetails;
        double totalWeight = 0;
        public OrderPage(Order order)
        {
            InitializeComponent();
            this.order = order;
        }

        private void Order_Load(object sender, EventArgs e)
        {
            List<CartProductDetail> orderProductDetails = new List<CartProductDetail>();
            DataBase db = new DataBase();
            orderDetails = db.GetOrderDetailWithOrderId(order.orderId);
            CartProductDetail orderProductDetail;
            Product product;
            foreach (OrderDetail orderDetail in orderDetails)
            {
                product = db.GetProductWithProductId(orderDetail.productId);
                orderProductDetail = new CartProductDetail()
                {
                    id = product.id,
                    name = product.name,
                    description = product.description,
                    weight = product.weight,
                    price = product.price,
                    tax = product.tax,
                    totalPriceWTax = product.totalPriceWTax,
                    image = product.image,
                    quantity = orderDetail.quantity
                };
                totalWeight += product.weight*orderDetail.quantity;
                orderProductDetails.Add(orderProductDetail);
                orderItemList.Rows.Add(product.id,product.name,product.description,product.weight,product.price,product.tax,product.totalPriceWTax,product.image,orderDetail.quantity,product.price*orderDetail.quantity);
            }
            dateLabel.Text = order.date;
            totalWeightLabel.Text = totalWeight + "kg";
            totalPriceLabel.Text = order.payment.paymentAmount+"$";
            paymentType.Text = order.payment.paymentType;
            orderStatus.Text = order.status;
        }
    
    }
}
