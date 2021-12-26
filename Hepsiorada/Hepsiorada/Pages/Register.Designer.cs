namespace Hepsiorada
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.userName = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.province = new System.Windows.Forms.TextBox();
            this.district = new System.Windows.Forms.TextBox();
            this.neighbourhood = new System.Windows.Forms.TextBox();
            this.addressDetail = new System.Windows.Forms.RichTextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.adminLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.Gray;
            this.userName.Location = new System.Drawing.Point(70, 119);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(269, 29);
            this.userName.TabIndex = 1;
            this.userName.Text = "User Name";
            this.userName.Enter += new System.EventHandler(this.userName_Enter);
            this.userName.Leave += new System.EventHandler(this.userName_Leave);
            // 
            // userPassword
            // 
            this.userPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPassword.ForeColor = System.Drawing.Color.Gray;
            this.userPassword.Location = new System.Drawing.Point(70, 154);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(269, 29);
            this.userPassword.TabIndex = 2;
            this.userPassword.Text = "User Password";
            this.userPassword.Enter += new System.EventHandler(this.userPassword_Enter);
            this.userPassword.Leave += new System.EventHandler(this.userPassword_Leave);
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Gray;
            this.name.Location = new System.Drawing.Point(70, 189);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(269, 29);
            this.name.TabIndex = 3;
            this.name.Text = "Name";
            this.name.Enter += new System.EventHandler(this.name_Enter);
            this.name.Leave += new System.EventHandler(this.name_Leave);
            // 
            // province
            // 
            this.province.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.province.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.province.ForeColor = System.Drawing.Color.Gray;
            this.province.Location = new System.Drawing.Point(0, 17);
            this.province.Name = "province";
            this.province.Size = new System.Drawing.Size(269, 29);
            this.province.TabIndex = 4;
            this.province.Text = "Province";
            this.province.Enter += new System.EventHandler(this.province_Enter);
            this.province.Leave += new System.EventHandler(this.province_Leave);
            // 
            // district
            // 
            this.district.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.district.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.district.ForeColor = System.Drawing.Color.Gray;
            this.district.Location = new System.Drawing.Point(0, 52);
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(269, 29);
            this.district.TabIndex = 5;
            this.district.Text = "District";
            this.district.Enter += new System.EventHandler(this.district_Enter);
            this.district.Leave += new System.EventHandler(this.district_Leave);
            // 
            // neighbourhood
            // 
            this.neighbourhood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.neighbourhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neighbourhood.ForeColor = System.Drawing.Color.Gray;
            this.neighbourhood.Location = new System.Drawing.Point(0, 87);
            this.neighbourhood.Name = "neighbourhood";
            this.neighbourhood.Size = new System.Drawing.Size(269, 29);
            this.neighbourhood.TabIndex = 6;
            this.neighbourhood.Text = "Neighbourhood";
            this.neighbourhood.Enter += new System.EventHandler(this.neighbourhood_Enter);
            this.neighbourhood.Leave += new System.EventHandler(this.neighbourhood_Leave);
            // 
            // addressDetail
            // 
            this.addressDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressDetail.ForeColor = System.Drawing.Color.Gray;
            this.addressDetail.Location = new System.Drawing.Point(0, 122);
            this.addressDetail.Name = "addressDetail";
            this.addressDetail.Size = new System.Drawing.Size(269, 96);
            this.addressDetail.TabIndex = 7;
            this.addressDetail.Text = "Address Detail";
            this.addressDetail.Enter += new System.EventHandler(this.addressDetail_Enter);
            this.addressDetail.Leave += new System.EventHandler(this.addressDetail_Leave);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.White;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Image = global::Hepsiorada.Properties.Resources.register;
            this.registerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registerButton.Location = new System.Drawing.Point(70, 448);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(269, 53);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            this.registerButton.MouseLeave += new System.EventHandler(this.registerButton_MouseLeave);
            this.registerButton.MouseHover += new System.EventHandler(this.registerButton_MouseHover);
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.ForeColor = System.Drawing.Color.Tomato;
            this.adminLabel.Location = new System.Drawing.Point(144, 66);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(125, 37);
            this.adminLabel.TabIndex = 15;
            this.adminLabel.Text = "ADMIN";
            this.adminLabel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Press CTRL + A for admin register.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hepsiorada.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(44, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addressDetail);
            this.groupBox1.Controls.Add(this.province);
            this.groupBox1.Controls.Add(this.district);
            this.groupBox1.Controls.Add(this.neighbourhood);
            this.groupBox1.Location = new System.Drawing.Point(70, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 218);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.name);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register | Hepsiorada";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox province;
        private System.Windows.Forms.TextBox district;
        private System.Windows.Forms.TextBox neighbourhood;
        private System.Windows.Forms.RichTextBox addressDetail;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}