using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Hepsiorada.Classes
{
    public class DataBase
    {
        private OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+ System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Resources\\Database\\Hepsiorada.mdb");
        private OleDbCommand command = new OleDbCommand();
        private OleDbDataReader reader;
        public DataBase()
        {
            command.Connection = connection;
        }
        public Boolean Register(Customer customer)
        {
            connection.Open();
            command.CommandText = "Select * From Users Where userName='" + customer.userName + "'";
            OleDbDataReader reader = command.ExecuteReader();
            Boolean isUsernameUsable = !reader.Read();
            connection.Close();
        
            if (isUsernameUsable)
            {
                connection.Open();
                command.CommandText = "Insert into Users (userName,userPassword,isAdmin,uName) values('" + customer.userName + "','" + customer.userPassword + "'," + customer.isAdmin + ",'" + customer.name + "');";
                command.ExecuteNonQuery();
                command.CommandText = "SELECT @@IDENTITY;";
                customer.userId = (int)command.ExecuteScalar();
                connection.Close();
                OperationDB("Insert into Address (userId,province,district,neighbourhood,addressDetail) values(" + customer.userId + ",'" + customer.address.province + "','" + customer.address.district + "','" + customer.address.neighbourhood + "','" + customer.address.addressDetail + "')");
                foreach(CartProductDetail productDetail in customer.cartItems)
                    OperationDB("Insert into UserCartItems (productId,userId,quantity) values(" + productDetail.id + "," + customer.userId + "," + productDetail.quantity + ")");
            }
            return isUsernameUsable;
        }
        public Boolean Login(Customer customer)
        {
            connection.Open();
            command.CommandText = "Select * From Users Where userName='" + customer.userName + "' and userPassword='" + customer.userPassword + "'";
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int userId = (int)reader["userId"];
                customer.userId = userId;
                customer.name = reader["uName"].ToString();
                customer.isAdmin = (Boolean)reader["isAdmin"];
                connection.Close();
                customer.address = GetAddressWithUserId(userId);
                customer.cartItems = GetCartItemsWithUserId(userId);
                customer.orders = GetOrdersWithUserId(userId);
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        public Customer UpdateCustomer(Customer customer)
        {
            OperationDB("Update Users set userPassword='" + customer.userPassword + "' , uName='" + customer.name + "' Where userId=" + customer.userId);
            OperationDB("Update Address set province='"+customer.address.province+"', district='"+customer.address.district+"', neighbourhood='"+customer.address.neighbourhood+"', addressDetail='"+customer.address.addressDetail+"' Where userId=" + customer.userId);
            return customer;
        }
        public void DeleteCustomer(int userId)
        {
            OperationDB("Delete from Users Where userId="+userId);
            //OperationDB("Delete from Address Where userId="+userId);
        }
        public Customer GetCustomerWithId(int userId)
        {
            Customer customer = new Customer();
            connection.Open();
            command.CommandText = "Select * From Users Where userId="+userId;
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                customer = new Customer() {
                    userId = (int)reader["userId"],
                    userName = reader["userName"].ToString(),
                    userPassword = reader["userPassword"].ToString(),
                    name = reader["uName"].ToString(),
                    isAdmin = (Boolean)reader["isAdmin"],
                };
                connection.Close();
                customer.address = GetAddressWithUserId(customer.userId);
                customer.cartItems = GetCartItemsWithUserId(customer.userId);
                customer.orders = GetOrdersWithUserId(customer.userId);
            }       
            return customer;
        }
        public List<Order> GetOrdersWithUserId(int userId)
        {
            List<Order> orders = new List<Order>();
            connection.Open();
            command.CommandText = "Select * From Orders Where userId=" + userId;

            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                orders.Add(new Order()
                {
                    orderId = (int)reader["orderId"],
                    paymentId = (int)reader["paymentId"],
                    date = reader["orderDate"].ToString(),
                    status = reader["orderStatus"].ToString()
                });
            }
            connection.Close();
            Payment payment;
            foreach (Order order in orders)
            {
                connection.Open();
                command.CommandText = "Select * from Payment Where paymentId=" + order.paymentId;
                reader = command.ExecuteReader();
                reader.Read();
                payment = new Payment()
                {
                    paymentId = order.paymentId,
                    paymentAmount = Convert.ToDouble(reader["paymentAmount"]),
                    paymentType = reader["paymentType"].ToString()
                };
                connection.Close();
                order.payment = payment;
            }
            return orders;
        }
        public List<OrderDetail> GetOrderDetailWithOrderId(int orderId)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            command.CommandText = "Select * From OrderDetail Where orderId=" + orderId;
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                orderDetails.Add(new OrderDetail() {
                    orderDetailId = (int)reader["orderDetailId"],
                    productId = (int)reader["productId"],
                    quantity = (int)reader["quantity"]
                });
            }
            connection.Close();
            return orderDetails;
        }
        public List<Product> GetProductList()
        {
            List<Product> products = new List<Product>();
            Product product;
            connection.Open();
            command.CommandText = "Select * From Products";
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                product = new Product()
                {
                    id = (int)reader["productId"],
                    name = reader["productName"].ToString(),
                    description = reader["productDescription"].ToString(),
                    weight = Convert.ToDouble(reader["productWeight"]),
                    price = Convert.ToDouble(reader["productPrice"]),
                    tax = Convert.ToInt32(reader["productTax"]),
                    totalPriceWTax = Convert.ToDouble(reader["productTotalPrice"]),
                    stock = Convert.ToInt32(reader["productStock"]),
                    image = byteArrayToImage((byte[])reader["productImage"])
                };
                products.Add(product);
            }
            connection.Close();
            return products;
        }
        public Product GetProductWithProductId(int productId)
        {
            Product product = new Product();
            connection.Open();
            command.CommandText = "Select * From Products Where productId=" + productId;
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                product = new Product()
                {
                    id = productId,
                    name = reader["productName"].ToString(),
                    description = reader["productDescription"].ToString(),
                    weight = Convert.ToDouble(reader["productWeight"]),
                    price = Convert.ToDouble(reader["productPrice"]),
                    tax = Convert.ToInt32(reader["productTax"]),
                    totalPriceWTax = Convert.ToDouble(reader["productTotalPrice"]),
                    stock = Convert.ToInt32(reader["productStock"]),
                    image = byteArrayToImage((byte[])reader["productImage"])
                };
            }
            connection.Close();
            return product;
        }
        public Address GetAddressWithUserId(int userId)
        {
            Address address;
            connection.Open();
            command.CommandText = "Select * From Address Where userId=" + userId;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                address = new Address() {
                    province = reader["province"].ToString(),
                    district = reader["district"].ToString(),
                    neighbourhood = reader["neighbourhood"].ToString(),
                    addressDetail = reader["addressDetail"].ToString()
                };
            }
            else
                address = new Address();
            connection.Close();
            return address;
        }
        public List<CartProductDetail> GetCartItemsWithUserId(int userId)
        {
            List<CartProductDetail> cartItems = new List<CartProductDetail>();
            command.CommandText = "Select * From UserCartItems Where userId=" + userId;
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                CartProductDetail cartProductDetail = new CartProductDetail() { id = (int)reader["productId"], quantity = (int)reader["quantity"] };
                cartItems.Add(cartProductDetail);
            }
            connection.Close();

            foreach (CartProductDetail cartItem in cartItems)
            {
                connection.Open();
                command.CommandText = "Select * From Products Where productId=" + cartItem.id;
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    cartItem.name = reader["productName"].ToString();
                    cartItem.description = reader["productDescription"].ToString();
                    cartItem.weight = Convert.ToDouble(reader["productWeight"]);
                    cartItem.price = Convert.ToDouble(reader["productPrice"]);
                    cartItem.tax = Convert.ToInt32(reader["productTax"]);
                    cartItem.totalPriceWTax= Convert.ToDouble(reader["productTotalPrice"]);
                    cartItem.stock = Convert.ToInt32(reader["productStock"]);
                    cartItem.image = byteArrayToImage((byte[])reader["productImage"]);
                }
                connection.Close();
                cartItem.quantity = cartItem.quantity; //This is for to run set prop
            }
            return cartItems;
        }
        public List<Customer> GetAllUsers()
        {
            List<Customer> customers = new List<Customer>();
            connection.Open();
            command.CommandText = "Select * From Users";
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                customers.Add(new Customer()
                {
                    userId = (int)reader["userId"],
                    userName = reader["userName"].ToString(),
                    userPassword = reader["userPassword"].ToString(),
                    name = reader["uName"].ToString(),
                    isAdmin = (Boolean)reader["isAdmin"]
                });
            }
            connection.Close();
            foreach(Customer customer in customers)
            {
                customer.address = GetAddressWithUserId(customer.userId);
                customer.cartItems = GetCartItemsWithUserId(customer.userId);
                customer.orders = GetOrdersWithUserId(customer.userId);
            }
            return customers;
        }
        
        public void cartProductRemove(int productId, int userId)
        {
            OperationDB("DELETE from UserCartItems where userId =" + userId + " and productId=" + productId);
        }
        public void cartProductUpdate(CartProductDetail product, int userId, Boolean isRemove)
        {
            if (product.quantity == 0)
                cartProductRemove(product.id, userId);
            else
            {
                if (isRemove || product.quantity != 1)
                    OperationDB("Update UserCartItems set quantity=" + product.quantity + " Where userId=" + userId + " and productId=" + product.id);
                else
                    OperationDB("Insert into UserCartItems (productId,userId,quantity) values(" + product.id + "," + userId + "," + product.quantity + ")");
            }
        }

        public void AddProduct(Product product)
        {
            OleDbParameter param = new OleDbParameter();
            param.OleDbType = OleDbType.Binary;
            param.ParameterName = "Image";
            param.Value = ImageToBytes(product.image, ImageFormat.Png);
            command.Parameters.Add(param);
            OperationDB("Insert into Products (productName,productDescription,productWeight,productPrice,productTax,productTotalPrice,productStock,productImage) values('" + product.name + "','" + product.description + "',"+product.weight+ ","+ product.price.ToString().Replace(",", ".")+","+product.tax+","+product.totalPriceWTax.ToString().Replace(",", ".") + ","+product.stock + ", @Image)");
        }
        public void DeleteProduct(Product product)
        {
            OperationDB("DELETE from Products where productId =" + product.id);
        }
        public void UpdateProduct(Product product)
        {
            OleDbParameter param = new OleDbParameter();
            param.OleDbType = OleDbType.Binary;
            param.ParameterName = "Image";
            param.Value = ImageToBytes(product.image, ImageFormat.Png);
            command.Parameters.Add(param);
            OperationDB("Update Products set productName='" + product.name + "' ,productDescription='" + product.description +"',productWeight="+product.weight+ ",productPrice = " + product.price.ToString().Replace(",", ".") +",productTax="+product.tax+",productTotalPrice="+ product.totalPriceWTax.ToString().Replace(",", ".")+",productStock="+product.stock + ",productImage=@Image Where productId=" + product.id);
        }
        public void Payment(Customer customer, Payment payment, object paymentType)
        {
            connection.Open();
            command.CommandText = "Insert into Payment (paymentType,paymentAmount) values('" + payment.paymentType + "'," + payment.paymentAmount.ToString().Replace(",", ".") + ");";
            command.ExecuteNonQuery();
            command.CommandText = "SELECT @@IDENTITY;";
            payment.paymentId = (int)command.ExecuteScalar();
            connection.Close();
            connection.Open();
            command.CommandText = "Insert into Orders (userId,paymentId,orderDate,orderStatus) values(" + customer.userId + "," + payment.paymentId + ",'"+(DateTime.Now.ToString())+"','Preparing')";
            command.ExecuteNonQuery();
            command.CommandText = "SELECT @@IDENTITY;";
            int orderId = (int)command.ExecuteScalar();
            connection.Close();
            switch (payment.paymentType)
            {
                case "Credit":
                    PCredit credit = (PCredit)paymentType;
                    OperationDB("Insert into PCredit (paymentId,creditNumber, expDate, cvc) values(" + payment.paymentId +",'"+credit.number +"','"+credit.expDate+"','"+credit.cvc+"')");
                    break;
                case "Pay at the door":
                    PPayDor payDoor = (PPayDor)paymentType;
                    OperationDB("Insert into PPayDoor (paymentId,payersName, paymentType) values(" + payment.paymentId + ",'" + payDoor.payersName+ "','" + payDoor.paymentType+"')");
                    break;
            }
            foreach (CartProductDetail cartProduct in customer.cartItems)
            {
                OperationDB("Insert into OrderDetail (orderId,productId,quantity) values("+orderId+","+cartProduct.id+","+cartProduct.quantity+")");
                OperationDB("Update Products set productStock="+(cartProduct.stock - cartProduct.quantity)+" Where productId=" + cartProduct.id);
            }
        }

        private byte[] ImageToBytes(Image image, ImageFormat format)
        {
            using (MemoryStream image_stream = new MemoryStream())
            {
                image.Save(image_stream, format);
                return image_stream.ToArray();
            }
        }
        private Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        public void OperationDB(string commandText)
        {
            connection.Open();
            command.CommandText = commandText;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
