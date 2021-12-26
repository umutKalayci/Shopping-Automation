namespace Hepsiorada.Pages
{
    partial class PaymentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentPage));
            this.payButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.payDoorRadio = new System.Windows.Forms.RadioButton();
            this.creditCardRadio = new System.Windows.Forms.RadioButton();
            this.creditCardCVC = new System.Windows.Forms.TextBox();
            this.creditExpDate = new System.Windows.Forms.TextBox();
            this.creditCardNumber = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.payDoorGroup = new System.Windows.Forms.GroupBox();
            this.payersName = new System.Windows.Forms.TextBox();
            this.payBox = new System.Windows.Forms.GroupBox();
            this.payCash = new System.Windows.Forms.RadioButton();
            this.payCreditCart = new System.Windows.Forms.RadioButton();
            this.creditCardGroup = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.payDoorGroup.SuspendLayout();
            this.payBox.SuspendLayout();
            this.creditCardGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(232, 398);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(75, 23);
            this.payButton.TabIndex = 0;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.payDoorRadio);
            this.groupBox1.Controls.Add(this.creditCardRadio);
            this.groupBox1.Location = new System.Drawing.Point(19, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Method";
            // 
            // payDoorRadio
            // 
            this.payDoorRadio.AutoSize = true;
            this.payDoorRadio.Location = new System.Drawing.Point(90, 20);
            this.payDoorRadio.Name = "payDoorRadio";
            this.payDoorRadio.Size = new System.Drawing.Size(97, 17);
            this.payDoorRadio.TabIndex = 2;
            this.payDoorRadio.Text = "Pay at the door";
            this.payDoorRadio.UseVisualStyleBackColor = true;
            this.payDoorRadio.CheckedChanged += new System.EventHandler(this.payDoorRadio_CheckedChanged);
            // 
            // creditCardRadio
            // 
            this.creditCardRadio.AutoSize = true;
            this.creditCardRadio.Checked = true;
            this.creditCardRadio.Location = new System.Drawing.Point(7, 20);
            this.creditCardRadio.Name = "creditCardRadio";
            this.creditCardRadio.Size = new System.Drawing.Size(77, 17);
            this.creditCardRadio.TabIndex = 0;
            this.creditCardRadio.TabStop = true;
            this.creditCardRadio.Text = "Credit Card";
            this.creditCardRadio.UseVisualStyleBackColor = true;
            this.creditCardRadio.CheckedChanged += new System.EventHandler(this.creditCardRadio_CheckedChanged);
            // 
            // creditCardCVC
            // 
            this.creditCardCVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCardCVC.ForeColor = System.Drawing.Color.Gray;
            this.creditCardCVC.Location = new System.Drawing.Point(17, 168);
            this.creditCardCVC.MaxLength = 3;
            this.creditCardCVC.Name = "creditCardCVC";
            this.creditCardCVC.Size = new System.Drawing.Size(49, 29);
            this.creditCardCVC.TabIndex = 5;
            this.creditCardCVC.Text = "CVC";
            this.creditCardCVC.Enter += new System.EventHandler(this.creditCardCVC_Enter);
            this.creditCardCVC.Leave += new System.EventHandler(this.creditCardCVC_Leave);
            // 
            // creditExpDate
            // 
            this.creditExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditExpDate.ForeColor = System.Drawing.Color.Gray;
            this.creditExpDate.Location = new System.Drawing.Point(17, 105);
            this.creditExpDate.Name = "creditExpDate";
            this.creditExpDate.Size = new System.Drawing.Size(256, 29);
            this.creditExpDate.TabIndex = 4;
            this.creditExpDate.Text = "Exp Date";
            this.creditExpDate.Enter += new System.EventHandler(this.creditExpDate_Enter);
            this.creditExpDate.Leave += new System.EventHandler(this.creditExpDate_Leave);
            // 
            // creditCardNumber
            // 
            this.creditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCardNumber.ForeColor = System.Drawing.Color.Gray;
            this.creditCardNumber.Location = new System.Drawing.Point(17, 44);
            this.creditCardNumber.Name = "creditCardNumber";
            this.creditCardNumber.Size = new System.Drawing.Size(256, 29);
            this.creditCardNumber.TabIndex = 3;
            this.creditCardNumber.Text = "Card Number";
            this.creditCardNumber.Enter += new System.EventHandler(this.creditCardNumber_Enter);
            this.creditCardNumber.Leave += new System.EventHandler(this.creditCardNumber_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hepsiorada.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(19, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // payDoorGroup
            // 
            this.payDoorGroup.Controls.Add(this.payersName);
            this.payDoorGroup.Controls.Add(this.payBox);
            this.payDoorGroup.Location = new System.Drawing.Point(19, 147);
            this.payDoorGroup.Name = "payDoorGroup";
            this.payDoorGroup.Size = new System.Drawing.Size(288, 245);
            this.payDoorGroup.TabIndex = 6;
            this.payDoorGroup.TabStop = false;
            this.payDoorGroup.Text = "Payer\'s Information";
            this.payDoorGroup.Visible = false;
            // 
            // payersName
            // 
            this.payersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payersName.ForeColor = System.Drawing.Color.Gray;
            this.payersName.Location = new System.Drawing.Point(17, 79);
            this.payersName.Name = "payersName";
            this.payersName.Size = new System.Drawing.Size(256, 29);
            this.payersName.TabIndex = 1;
            this.payersName.Text = "Payer\'s Name";
            this.payersName.Enter += new System.EventHandler(this.payersName_Enter);
            this.payersName.Leave += new System.EventHandler(this.payersName_Leave);
            // 
            // payBox
            // 
            this.payBox.Controls.Add(this.payCash);
            this.payBox.Controls.Add(this.payCreditCart);
            this.payBox.Location = new System.Drawing.Point(17, 168);
            this.payBox.Name = "payBox";
            this.payBox.Size = new System.Drawing.Size(256, 45);
            this.payBox.TabIndex = 0;
            this.payBox.TabStop = false;
            this.payBox.Text = "Pay With:";
            // 
            // payCash
            // 
            this.payCash.AutoSize = true;
            this.payCash.Location = new System.Drawing.Point(89, 19);
            this.payCash.Name = "payCash";
            this.payCash.Size = new System.Drawing.Size(49, 17);
            this.payCash.TabIndex = 1;
            this.payCash.Text = "Cash";
            this.payCash.UseVisualStyleBackColor = true;
            // 
            // payCreditCart
            // 
            this.payCreditCart.AutoSize = true;
            this.payCreditCart.Checked = true;
            this.payCreditCart.Location = new System.Drawing.Point(6, 19);
            this.payCreditCart.Name = "payCreditCart";
            this.payCreditCart.Size = new System.Drawing.Size(77, 17);
            this.payCreditCart.TabIndex = 0;
            this.payCreditCart.TabStop = true;
            this.payCreditCart.Text = "Credit Card";
            this.payCreditCart.UseVisualStyleBackColor = true;
            // 
            // creditCardGroup
            // 
            this.creditCardGroup.Controls.Add(this.creditCardCVC);
            this.creditCardGroup.Controls.Add(this.creditExpDate);
            this.creditCardGroup.Controls.Add(this.creditCardNumber);
            this.creditCardGroup.Location = new System.Drawing.Point(19, 147);
            this.creditCardGroup.Name = "creditCardGroup";
            this.creditCardGroup.Size = new System.Drawing.Size(288, 245);
            this.creditCardGroup.TabIndex = 7;
            this.creditCardGroup.TabStop = false;
            this.creditCardGroup.Text = "Credit Cards Information";
            // 
            // PaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.payDoorGroup);
            this.Controls.Add(this.creditCardGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PaymentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment | Hepsiorada";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.payDoorGroup.ResumeLayout(false);
            this.payDoorGroup.PerformLayout();
            this.payBox.ResumeLayout(false);
            this.payBox.PerformLayout();
            this.creditCardGroup.ResumeLayout(false);
            this.creditCardGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton creditCardRadio;
        private System.Windows.Forms.TextBox creditCardCVC;
        private System.Windows.Forms.TextBox creditExpDate;
        private System.Windows.Forms.TextBox creditCardNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton payDoorRadio;
        private System.Windows.Forms.GroupBox payDoorGroup;
        private System.Windows.Forms.TextBox payersName;
        private System.Windows.Forms.GroupBox payBox;
        private System.Windows.Forms.RadioButton payCash;
        private System.Windows.Forms.RadioButton payCreditCart;
        private System.Windows.Forms.GroupBox creditCardGroup;
    }
}