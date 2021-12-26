namespace Hepsiorada.Pages
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.label1 = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.userPasswordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userFullNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addressDetailBox = new System.Windows.Forms.RichTextBox();
            this.neighbourhoodBox = new System.Windows.Forms.TextBox();
            this.districtBox = new System.Windows.Forms.TextBox();
            this.provinceBox = new System.Windows.Forms.TextBox();
            this.saveProfileButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.orderList = new System.Windows.Forms.DataGridView();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // userNameBox
            // 
            this.userNameBox.Enabled = false;
            this.userNameBox.Location = new System.Drawing.Point(97, 36);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(139, 20);
            this.userNameBox.TabIndex = 1;
            // 
            // userPasswordBox
            // 
            this.userPasswordBox.Location = new System.Drawing.Point(97, 62);
            this.userPasswordBox.Name = "userPasswordBox";
            this.userPasswordBox.Size = new System.Drawing.Size(139, 20);
            this.userPasswordBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // userFullNameBox
            // 
            this.userFullNameBox.Location = new System.Drawing.Point(97, 88);
            this.userFullNameBox.Name = "userFullNameBox";
            this.userFullNameBox.Size = new System.Drawing.Size(139, 20);
            this.userFullNameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.addressDetailBox);
            this.groupBox1.Controls.Add(this.neighbourhoodBox);
            this.groupBox1.Controls.Add(this.districtBox);
            this.groupBox1.Controls.Add(this.provinceBox);
            this.groupBox1.Controls.Add(this.userNameBox);
            this.groupBox1.Controls.Add(this.saveProfileButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.userFullNameBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.userPasswordBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 367);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Profile";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Address Detail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Neighbourhood:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "District:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Province:";
            // 
            // addressDetailBox
            // 
            this.addressDetailBox.Location = new System.Drawing.Point(97, 196);
            this.addressDetailBox.Name = "addressDetailBox";
            this.addressDetailBox.Size = new System.Drawing.Size(139, 96);
            this.addressDetailBox.TabIndex = 7;
            this.addressDetailBox.Text = "";
            // 
            // neighbourhoodBox
            // 
            this.neighbourhoodBox.Location = new System.Drawing.Point(97, 169);
            this.neighbourhoodBox.Name = "neighbourhoodBox";
            this.neighbourhoodBox.Size = new System.Drawing.Size(139, 20);
            this.neighbourhoodBox.TabIndex = 6;
            // 
            // districtBox
            // 
            this.districtBox.Location = new System.Drawing.Point(97, 142);
            this.districtBox.Name = "districtBox";
            this.districtBox.Size = new System.Drawing.Size(139, 20);
            this.districtBox.TabIndex = 5;
            // 
            // provinceBox
            // 
            this.provinceBox.Location = new System.Drawing.Point(97, 115);
            this.provinceBox.Name = "provinceBox";
            this.provinceBox.Size = new System.Drawing.Size(139, 20);
            this.provinceBox.TabIndex = 4;
            // 
            // saveProfileButton
            // 
            this.saveProfileButton.BackColor = System.Drawing.Color.White;
            this.saveProfileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saveProfileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saveProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveProfileButton.ForeColor = System.Drawing.Color.Black;
            this.saveProfileButton.Image = global::Hepsiorada.Properties.Resources.save;
            this.saveProfileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveProfileButton.Location = new System.Drawing.Point(31, 298);
            this.saveProfileButton.Name = "saveProfileButton";
            this.saveProfileButton.Size = new System.Drawing.Size(189, 45);
            this.saveProfileButton.TabIndex = 8;
            this.saveProfileButton.Text = "Save";
            this.saveProfileButton.UseVisualStyleBackColor = false;
            this.saveProfileButton.Click += new System.EventHandler(this.saveProfileButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.orderList);
            this.groupBox2.Location = new System.Drawing.Point(293, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 426);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your Orders";
            // 
            // orderList
            // 
            this.orderList.AllowUserToAddRows = false;
            this.orderList.AllowUserToDeleteRows = false;
            this.orderList.AllowUserToResizeColumns = false;
            this.orderList.AllowUserToResizeRows = false;
            this.orderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.orderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderId,
            this.orderDate,
            this.orderStatus,
            this.paymentType,
            this.orderPrice,
            this.viewDetail});
            this.orderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderList.Location = new System.Drawing.Point(3, 16);
            this.orderList.MultiSelect = false;
            this.orderList.Name = "orderList";
            this.orderList.ReadOnly = true;
            this.orderList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.orderList.RowTemplate.Height = 40;
            this.orderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.orderList.Size = new System.Drawing.Size(489, 407);
            this.orderList.TabIndex = 19;
            this.orderList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderList_CellContentClick);
            // 
            // orderId
            // 
            this.orderId.HeaderText = "Order Id";
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            // 
            // orderDate
            // 
            this.orderDate.HeaderText = "Order Date";
            this.orderDate.Name = "orderDate";
            this.orderDate.ReadOnly = true;
            // 
            // orderStatus
            // 
            this.orderStatus.HeaderText = "Order Status";
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.ReadOnly = true;
            // 
            // paymentType
            // 
            this.paymentType.HeaderText = "Payment Type";
            this.paymentType.Name = "paymentType";
            this.paymentType.ReadOnly = true;
            // 
            // orderPrice
            // 
            this.orderPrice.HeaderText = "Order Price";
            this.orderPrice.Name = "orderPrice";
            this.orderPrice.ReadOnly = true;
            // 
            // viewDetail
            // 
            this.viewDetail.HeaderText = "View Detail";
            this.viewDetail.Name = "viewDetail";
            this.viewDetail.ReadOnly = true;
            this.viewDetail.Text = "View Detail";
            this.viewDetail.UseColumnTextForButtonValue = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hepsiorada.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile | Hepsiorada";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox userPasswordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userFullNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveProfileButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView orderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPrice;
        private System.Windows.Forms.DataGridViewButtonColumn viewDetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox addressDetailBox;
        private System.Windows.Forms.TextBox neighbourhoodBox;
        private System.Windows.Forms.TextBox districtBox;
        private System.Windows.Forms.TextBox provinceBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}