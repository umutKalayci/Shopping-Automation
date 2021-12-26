namespace Hepsiorada
{
    partial class Home_Page
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Page));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.cartQuantityLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.cartButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.productList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminLabel = new System.Windows.Forms.Label();
            this.userManagerButton = new System.Windows.Forms.Button();
            this.productManagerButton = new System.Windows.Forms.Button();
            this.menuLastProductMenu = new System.Windows.Forms.Button();
            this.menuAllProductButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.allProductsPanel = new System.Windows.Forms.Panel();
            this.lastProductsPanel = new System.Windows.Forms.Panel();
            this.lastItemPanel3 = new System.Windows.Forms.Panel();
            this.lastProductPrice3 = new System.Windows.Forms.Label();
            this.lastProductButton3 = new System.Windows.Forms.Button();
            this.lastProductDescription3 = new System.Windows.Forms.Label();
            this.lastProductName3 = new System.Windows.Forms.Label();
            this.lastProductImage3 = new System.Windows.Forms.PictureBox();
            this.lastItemPanel2 = new System.Windows.Forms.Panel();
            this.lastProductPrice2 = new System.Windows.Forms.Label();
            this.lastProductButton2 = new System.Windows.Forms.Button();
            this.lastProductDescription2 = new System.Windows.Forms.Label();
            this.lastProductName2 = new System.Windows.Forms.Label();
            this.lastProductImage2 = new System.Windows.Forms.PictureBox();
            this.lastItemPanel1 = new System.Windows.Forms.Panel();
            this.lastProductPrice1 = new System.Windows.Forms.Label();
            this.lastProductButton1 = new System.Windows.Forms.Button();
            this.lastProductDescription1 = new System.Windows.Forms.Label();
            this.lastproductName1 = new System.Windows.Forms.Label();
            this.lastProductImage1 = new System.Windows.Forms.PictureBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.allProductsPanel.SuspendLayout();
            this.lastProductsPanel.SuspendLayout();
            this.lastItemPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastProductImage3)).BeginInit();
            this.lastItemPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastProductImage2)).BeginInit();
            this.lastItemPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastProductImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(20, 344);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(359, 134);
            this.listBox1.TabIndex = 13;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.cartQuantityLabel);
            this.headerPanel.Controls.Add(this.logoutButton);
            this.headerPanel.Controls.Add(this.registerButton);
            this.headerPanel.Controls.Add(this.cartButton);
            this.headerPanel.Controls.Add(this.loginButton);
            this.headerPanel.Controls.Add(this.profileButton);
            this.headerPanel.Location = new System.Drawing.Point(189, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(827, 55);
            this.headerPanel.TabIndex = 16;
            // 
            // cartQuantityLabel
            // 
            this.cartQuantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cartQuantityLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartQuantityLabel.Location = new System.Drawing.Point(795, -3);
            this.cartQuantityLabel.Name = "cartQuantityLabel";
            this.cartQuantityLabel.Size = new System.Drawing.Size(27, 17);
            this.cartQuantityLabel.TabIndex = 10;
            this.cartQuantityLabel.Text = "0";
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.Black;
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(530, -1);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(106, 55);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.TabStop = false;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutButton.UseMnemonic = false;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Visible = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            this.logoutButton.MouseEnter += new System.EventHandler(this.logoutButton_MouseEnter);
            this.logoutButton.MouseLeave += new System.EventHandler(this.logoutButton_MouseLeave);
            // 
            // registerButton
            // 
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.Black;
            this.registerButton.Image = global::Hepsiorada.Properties.Resources.register;
            this.registerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registerButton.Location = new System.Drawing.Point(517, -1);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(119, 55);
            this.registerButton.TabIndex = 1;
            this.registerButton.TabStop = false;
            this.registerButton.Text = "Register";
            this.registerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            this.registerButton.MouseEnter += new System.EventHandler(this.registerButton_MouseEnter);
            this.registerButton.MouseLeave += new System.EventHandler(this.registerButton_MouseLeave);
            // 
            // cartButton
            // 
            this.cartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartButton.FlatAppearance.BorderSize = 0;
            this.cartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartButton.ForeColor = System.Drawing.Color.Black;
            this.cartButton.Image = global::Hepsiorada.Properties.Resources.cart;
            this.cartButton.Location = new System.Drawing.Point(751, -1);
            this.cartButton.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(75, 55);
            this.cartButton.TabIndex = 2;
            this.cartButton.TabStop = false;
            this.cartButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cartButton.UseVisualStyleBackColor = true;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Image = global::Hepsiorada.Properties.Resources.login1;
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.Location = new System.Drawing.Point(654, -1);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(92, 55);
            this.loginButton.TabIndex = 0;
            this.loginButton.TabStop = false;
            this.loginButton.Text = "Login";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.loginButton.MouseEnter += new System.EventHandler(this.loginButton_MouseEnter);
            this.loginButton.MouseLeave += new System.EventHandler(this.loginButton_MouseLeave);
            // 
            // profileButton
            // 
            this.profileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.ForeColor = System.Drawing.Color.Black;
            this.profileButton.Image = global::Hepsiorada.Properties.Resources.login1;
            this.profileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileButton.Location = new System.Drawing.Point(642, -1);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(104, 55);
            this.profileButton.TabIndex = 8;
            this.profileButton.TabStop = false;
            this.profileButton.Text = "Profile";
            this.profileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Visible = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            this.profileButton.MouseEnter += new System.EventHandler(this.profileButton_MouseEnter);
            this.profileButton.MouseLeave += new System.EventHandler(this.profileButton_MouseLeave);
            // 
            // productList
            // 
            this.productList.AllowUserToAddRows = false;
            this.productList.AllowUserToDeleteRows = false;
            this.productList.AllowUserToResizeColumns = false;
            this.productList.AllowUserToResizeRows = false;
            this.productList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.description,
            this.weight,
            this.price,
            this.tax,
            this.totalPrice,
            this.stock,
            this.image,
            this.quantity,
            this.remove,
            this.add});
            this.productList.Location = new System.Drawing.Point(20, 8);
            this.productList.MultiSelect = false;
            this.productList.Name = "productList";
            this.productList.ReadOnly = true;
            this.productList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productList.RowTemplate.Height = 40;
            this.productList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.productList.Size = new System.Drawing.Size(764, 320);
            this.productList.TabIndex = 18;
            this.productList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productList_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(82)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.adminLabel);
            this.panel1.Controls.Add(this.userManagerButton);
            this.panel1.Controls.Add(this.productManagerButton);
            this.panel1.Controls.Add(this.menuLastProductMenu);
            this.panel1.Controls.Add(this.menuAllProductButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 555);
            this.panel1.TabIndex = 19;
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.BackColor = System.Drawing.Color.Transparent;
            this.adminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.ForeColor = System.Drawing.Color.Black;
            this.adminLabel.Location = new System.Drawing.Point(41, 492);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(142, 42);
            this.adminLabel.TabIndex = 25;
            this.adminLabel.Text = "ADMIN";
            this.adminLabel.Visible = false;
            // 
            // userManagerButton
            // 
            this.userManagerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userManagerButton.FlatAppearance.BorderSize = 0;
            this.userManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userManagerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagerButton.ForeColor = System.Drawing.Color.Black;
            this.userManagerButton.Image = global::Hepsiorada.Properties.Resources.userManager1;
            this.userManagerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userManagerButton.Location = new System.Drawing.Point(1, 279);
            this.userManagerButton.Name = "userManagerButton";
            this.userManagerButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.userManagerButton.Size = new System.Drawing.Size(225, 50);
            this.userManagerButton.TabIndex = 24;
            this.userManagerButton.Text = "User Management";
            this.userManagerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userManagerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userManagerButton.UseVisualStyleBackColor = true;
            this.userManagerButton.Visible = false;
            this.userManagerButton.Click += new System.EventHandler(this.userManagerButton_Click);
            // 
            // productManagerButton
            // 
            this.productManagerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productManagerButton.FlatAppearance.BorderSize = 0;
            this.productManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productManagerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productManagerButton.ForeColor = System.Drawing.Color.Black;
            this.productManagerButton.Image = global::Hepsiorada.Properties.Resources.productManager;
            this.productManagerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productManagerButton.Location = new System.Drawing.Point(2, 225);
            this.productManagerButton.Name = "productManagerButton";
            this.productManagerButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.productManagerButton.Size = new System.Drawing.Size(225, 50);
            this.productManagerButton.TabIndex = 23;
            this.productManagerButton.Text = "Product Management";
            this.productManagerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productManagerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productManagerButton.UseVisualStyleBackColor = true;
            this.productManagerButton.Visible = false;
            this.productManagerButton.Click += new System.EventHandler(this.productManagerButton_Click);
            // 
            // menuLastProductMenu
            // 
            this.menuLastProductMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuLastProductMenu.FlatAppearance.BorderSize = 0;
            this.menuLastProductMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuLastProductMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLastProductMenu.ForeColor = System.Drawing.Color.Black;
            this.menuLastProductMenu.Image = global::Hepsiorada.Properties.Resources.lastproduct;
            this.menuLastProductMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuLastProductMenu.Location = new System.Drawing.Point(2, 170);
            this.menuLastProductMenu.Name = "menuLastProductMenu";
            this.menuLastProductMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuLastProductMenu.Size = new System.Drawing.Size(225, 50);
            this.menuLastProductMenu.TabIndex = 22;
            this.menuLastProductMenu.Text = "Last Products";
            this.menuLastProductMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuLastProductMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuLastProductMenu.UseVisualStyleBackColor = true;
            this.menuLastProductMenu.Click += new System.EventHandler(this.menuLastProductMenu_Click_1);
            // 
            // menuAllProductButton
            // 
            this.menuAllProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAllProductButton.FlatAppearance.BorderSize = 0;
            this.menuAllProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuAllProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAllProductButton.ForeColor = System.Drawing.Color.Black;
            this.menuAllProductButton.Image = global::Hepsiorada.Properties.Resources.products;
            this.menuAllProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuAllProductButton.Location = new System.Drawing.Point(3, 116);
            this.menuAllProductButton.Name = "menuAllProductButton";
            this.menuAllProductButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuAllProductButton.Size = new System.Drawing.Size(225, 50);
            this.menuAllProductButton.TabIndex = 21;
            this.menuAllProductButton.Text = "All Products";
            this.menuAllProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuAllProductButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuAllProductButton.UseVisualStyleBackColor = true;
            this.menuAllProductButton.Click += new System.EventHandler(this.menuAllProductButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 55);
            this.panel2.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Hepsiorada.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(16, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // allProductsPanel
            // 
            this.allProductsPanel.BackColor = System.Drawing.Color.Transparent;
            this.allProductsPanel.Controls.Add(this.productList);
            this.allProductsPanel.Controls.Add(this.listBox1);
            this.allProductsPanel.Location = new System.Drawing.Point(218, 53);
            this.allProductsPanel.Name = "allProductsPanel";
            this.allProductsPanel.Size = new System.Drawing.Size(795, 496);
            this.allProductsPanel.TabIndex = 20;
            // 
            // lastProductsPanel
            // 
            this.lastProductsPanel.BackColor = System.Drawing.Color.Transparent;
            this.lastProductsPanel.Controls.Add(this.lastItemPanel3);
            this.lastProductsPanel.Controls.Add(this.lastItemPanel2);
            this.lastProductsPanel.Controls.Add(this.lastItemPanel1);
            this.lastProductsPanel.Location = new System.Drawing.Point(218, 50);
            this.lastProductsPanel.Name = "lastProductsPanel";
            this.lastProductsPanel.Size = new System.Drawing.Size(798, 502);
            this.lastProductsPanel.TabIndex = 23;
            this.lastProductsPanel.Visible = false;
            // 
            // lastItemPanel3
            // 
            this.lastItemPanel3.BackColor = System.Drawing.Color.White;
            this.lastItemPanel3.Controls.Add(this.lastProductPrice3);
            this.lastItemPanel3.Controls.Add(this.lastProductButton3);
            this.lastItemPanel3.Controls.Add(this.lastProductDescription3);
            this.lastItemPanel3.Controls.Add(this.lastProductName3);
            this.lastItemPanel3.Controls.Add(this.lastProductImage3);
            this.lastItemPanel3.Location = new System.Drawing.Point(536, 36);
            this.lastItemPanel3.Name = "lastItemPanel3";
            this.lastItemPanel3.Size = new System.Drawing.Size(258, 428);
            this.lastItemPanel3.TabIndex = 7;
            // 
            // lastProductPrice3
            // 
            this.lastProductPrice3.BackColor = System.Drawing.Color.Transparent;
            this.lastProductPrice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastProductPrice3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.lastProductPrice3.Location = new System.Drawing.Point(113, 338);
            this.lastProductPrice3.Name = "lastProductPrice3";
            this.lastProductPrice3.Size = new System.Drawing.Size(136, 24);
            this.lastProductPrice3.TabIndex = 6;
            this.lastProductPrice3.Text = "19,99$";
            this.lastProductPrice3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastProductButton3
            // 
            this.lastProductButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lastProductButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastProductButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastProductButton3.Image = global::Hepsiorada.Properties.Resources.addCart;
            this.lastProductButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lastProductButton3.Location = new System.Drawing.Point(5, 374);
            this.lastProductButton3.Name = "lastProductButton3";
            this.lastProductButton3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lastProductButton3.Size = new System.Drawing.Size(248, 51);
            this.lastProductButton3.TabIndex = 3;
            this.lastProductButton3.Text = "Add Cart";
            this.lastProductButton3.UseVisualStyleBackColor = true;
            this.lastProductButton3.Click += new System.EventHandler(this.lastProductButton3_Click);
            // 
            // lastProductDescription3
            // 
            this.lastProductDescription3.Location = new System.Drawing.Point(9, 212);
            this.lastProductDescription3.Name = "lastProductDescription3";
            this.lastProductDescription3.Size = new System.Drawing.Size(242, 99);
            this.lastProductDescription3.TabIndex = 2;
            this.lastProductDescription3.Text = "label3";
            // 
            // lastProductName3
            // 
            this.lastProductName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastProductName3.Location = new System.Drawing.Point(3, 169);
            this.lastProductName3.Name = "lastProductName3";
            this.lastProductName3.Size = new System.Drawing.Size(252, 31);
            this.lastProductName3.TabIndex = 1;
            this.lastProductName3.Text = "Name";
            // 
            // lastProductImage3
            // 
            this.lastProductImage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lastProductImage3.Location = new System.Drawing.Point(3, 3);
            this.lastProductImage3.Name = "lastProductImage3";
            this.lastProductImage3.Size = new System.Drawing.Size(252, 163);
            this.lastProductImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lastProductImage3.TabIndex = 0;
            this.lastProductImage3.TabStop = false;
            // 
            // lastItemPanel2
            // 
            this.lastItemPanel2.BackColor = System.Drawing.Color.White;
            this.lastItemPanel2.Controls.Add(this.lastProductPrice2);
            this.lastItemPanel2.Controls.Add(this.lastProductButton2);
            this.lastItemPanel2.Controls.Add(this.lastProductDescription2);
            this.lastItemPanel2.Controls.Add(this.lastProductName2);
            this.lastItemPanel2.Controls.Add(this.lastProductImage2);
            this.lastItemPanel2.Location = new System.Drawing.Point(272, 36);
            this.lastItemPanel2.Name = "lastItemPanel2";
            this.lastItemPanel2.Size = new System.Drawing.Size(258, 428);
            this.lastItemPanel2.TabIndex = 1;
            // 
            // lastProductPrice2
            // 
            this.lastProductPrice2.BackColor = System.Drawing.Color.Transparent;
            this.lastProductPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastProductPrice2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.lastProductPrice2.Location = new System.Drawing.Point(113, 338);
            this.lastProductPrice2.Name = "lastProductPrice2";
            this.lastProductPrice2.Size = new System.Drawing.Size(136, 24);
            this.lastProductPrice2.TabIndex = 6;
            this.lastProductPrice2.Text = "19,99$";
            this.lastProductPrice2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastProductButton2
            // 
            this.lastProductButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lastProductButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastProductButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastProductButton2.Image = global::Hepsiorada.Properties.Resources.addCart;
            this.lastProductButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lastProductButton2.Location = new System.Drawing.Point(5, 374);
            this.lastProductButton2.Name = "lastProductButton2";
            this.lastProductButton2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lastProductButton2.Size = new System.Drawing.Size(248, 51);
            this.lastProductButton2.TabIndex = 3;
            this.lastProductButton2.Text = "Add Cart";
            this.lastProductButton2.UseVisualStyleBackColor = true;
            this.lastProductButton2.Click += new System.EventHandler(this.lastProductButton2_Click);
            // 
            // lastProductDescription2
            // 
            this.lastProductDescription2.Location = new System.Drawing.Point(9, 212);
            this.lastProductDescription2.Name = "lastProductDescription2";
            this.lastProductDescription2.Size = new System.Drawing.Size(242, 99);
            this.lastProductDescription2.TabIndex = 2;
            this.lastProductDescription2.Text = "label3";
            // 
            // lastProductName2
            // 
            this.lastProductName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastProductName2.Location = new System.Drawing.Point(3, 169);
            this.lastProductName2.Name = "lastProductName2";
            this.lastProductName2.Size = new System.Drawing.Size(252, 31);
            this.lastProductName2.TabIndex = 1;
            this.lastProductName2.Text = "Name";
            // 
            // lastProductImage2
            // 
            this.lastProductImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lastProductImage2.Location = new System.Drawing.Point(3, 3);
            this.lastProductImage2.Name = "lastProductImage2";
            this.lastProductImage2.Size = new System.Drawing.Size(252, 163);
            this.lastProductImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lastProductImage2.TabIndex = 0;
            this.lastProductImage2.TabStop = false;
            // 
            // lastItemPanel1
            // 
            this.lastItemPanel1.BackColor = System.Drawing.Color.White;
            this.lastItemPanel1.Controls.Add(this.lastProductPrice1);
            this.lastItemPanel1.Controls.Add(this.lastProductButton1);
            this.lastItemPanel1.Controls.Add(this.lastProductDescription1);
            this.lastItemPanel1.Controls.Add(this.lastproductName1);
            this.lastItemPanel1.Controls.Add(this.lastProductImage1);
            this.lastItemPanel1.Location = new System.Drawing.Point(8, 36);
            this.lastItemPanel1.Name = "lastItemPanel1";
            this.lastItemPanel1.Size = new System.Drawing.Size(258, 428);
            this.lastItemPanel1.TabIndex = 0;
            // 
            // lastProductPrice1
            // 
            this.lastProductPrice1.BackColor = System.Drawing.Color.Transparent;
            this.lastProductPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastProductPrice1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.lastProductPrice1.Location = new System.Drawing.Point(115, 338);
            this.lastProductPrice1.Name = "lastProductPrice1";
            this.lastProductPrice1.Size = new System.Drawing.Size(136, 24);
            this.lastProductPrice1.TabIndex = 5;
            this.lastProductPrice1.Text = "19,99$";
            this.lastProductPrice1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastProductButton1
            // 
            this.lastProductButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lastProductButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastProductButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastProductButton1.Image = global::Hepsiorada.Properties.Resources.addCart;
            this.lastProductButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lastProductButton1.Location = new System.Drawing.Point(5, 374);
            this.lastProductButton1.Name = "lastProductButton1";
            this.lastProductButton1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lastProductButton1.Size = new System.Drawing.Size(248, 51);
            this.lastProductButton1.TabIndex = 3;
            this.lastProductButton1.Text = "Add Cart";
            this.lastProductButton1.UseVisualStyleBackColor = true;
            this.lastProductButton1.Click += new System.EventHandler(this.lastProductButton1_Click);
            // 
            // lastProductDescription1
            // 
            this.lastProductDescription1.Location = new System.Drawing.Point(9, 212);
            this.lastProductDescription1.Name = "lastProductDescription1";
            this.lastProductDescription1.Size = new System.Drawing.Size(242, 99);
            this.lastProductDescription1.TabIndex = 2;
            this.lastProductDescription1.Text = "label2";
            // 
            // lastproductName1
            // 
            this.lastproductName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastproductName1.Location = new System.Drawing.Point(3, 169);
            this.lastproductName1.Name = "lastproductName1";
            this.lastproductName1.Size = new System.Drawing.Size(252, 31);
            this.lastproductName1.TabIndex = 1;
            this.lastproductName1.Text = "Name";
            // 
            // lastProductImage1
            // 
            this.lastProductImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lastProductImage1.Location = new System.Drawing.Point(3, 3);
            this.lastProductImage1.Name = "lastProductImage1";
            this.lastProductImage1.Size = new System.Drawing.Size(252, 163);
            this.lastProductImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lastProductImage1.TabIndex = 0;
            this.lastProductImage1.TabStop = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // weight
            // 
            this.weight.HeaderText = "Weight(kg)";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price($)";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // tax
            // 
            this.tax.HeaderText = "Tax(%)";
            this.tax.Name = "tax";
            this.tax.ReadOnly = true;
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Tax Included($)";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // image
            // 
            this.image.HeaderText = "Image";
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Selected Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // remove
            // 
            this.remove.HeaderText = "Remove";
            this.remove.Name = "remove";
            this.remove.ReadOnly = true;
            this.remove.Text = "-";
            this.remove.UseColumnTextForButtonValue = true;
            // 
            // add
            // 
            this.add.HeaderText = "Add";
            this.add.Name = "add";
            this.add.ReadOnly = true;
            this.add.Text = "+";
            this.add.UseColumnTextForButtonValue = true;
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1014, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.allProductsPanel);
            this.Controls.Add(this.lastProductsPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page | Hepsiorada";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.allProductsPanel.ResumeLayout(false);
            this.lastProductsPanel.ResumeLayout(false);
            this.lastItemPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lastProductImage3)).EndInit();
            this.lastItemPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lastProductImage2)).EndInit();
            this.lastItemPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lastProductImage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.DataGridView productList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button menuAllProductButton;
        private System.Windows.Forms.Panel allProductsPanel;
        private System.Windows.Forms.Button menuLastProductMenu;
        private System.Windows.Forms.Panel lastProductsPanel;
        private System.Windows.Forms.Panel lastItemPanel1;
        private System.Windows.Forms.Button lastProductButton1;
        private System.Windows.Forms.Label lastProductDescription1;
        private System.Windows.Forms.Label lastproductName1;
        private System.Windows.Forms.PictureBox lastProductImage1;
        private System.Windows.Forms.Panel lastItemPanel2;
        private System.Windows.Forms.Button lastProductButton2;
        private System.Windows.Forms.Label lastProductDescription2;
        private System.Windows.Forms.Label lastProductName2;
        private System.Windows.Forms.PictureBox lastProductImage2;
        private System.Windows.Forms.Label lastProductPrice2;
        private System.Windows.Forms.Label lastProductPrice1;
        private System.Windows.Forms.Button userManagerButton;
        private System.Windows.Forms.Button productManagerButton;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Label cartQuantityLabel;
        private System.Windows.Forms.Panel lastItemPanel3;
        private System.Windows.Forms.Label lastProductPrice3;
        private System.Windows.Forms.Button lastProductButton3;
        private System.Windows.Forms.Label lastProductDescription3;
        private System.Windows.Forms.Label lastProductName3;
        private System.Windows.Forms.PictureBox lastProductImage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewButtonColumn remove;
        private System.Windows.Forms.DataGridViewButtonColumn add;
    }
}

