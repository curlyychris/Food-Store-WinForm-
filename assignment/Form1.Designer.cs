namespace assignment

{
    partial class FormOrder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnTakeAway = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbCityTakeAway = new System.Windows.Forms.ComboBox();
            this.lblCityTakeAway = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPhoneTakeAway = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblReview = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.btnDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelivery.Location = new System.Drawing.Point(201, 214);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(192, 59);
            this.btnDelivery.TabIndex = 1;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.UseVisualStyleBackColor = false;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            this.btnDelivery.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickButton);
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTakeAway.Location = new System.Drawing.Point(392, 214);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Size = new System.Drawing.Size(192, 59);
            this.btnTakeAway.TabIndex = 2;
            this.btnTakeAway.Text = "Take Away";
            this.btnTakeAway.UseVisualStyleBackColor = true;
            this.btnTakeAway.Click += new System.EventHandler(this.button2_Click);
            this.btnTakeAway.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickButton);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAddress.Location = new System.Drawing.Point(220, 336);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(217, 26);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Tag = "   Street Address *";
            this.txtAddress.Text = "   Street Address *";
            this.txtAddress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickEnterTextBox);
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.notNull_validating);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(453, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Tag = "   Apt. #";
            this.textBox1.Text = "   Apt. #";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickEnterTextBox);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aptNo_keyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPhone.Location = new System.Drawing.Point(220, 422);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(217, 26);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Tag = "   Phone *";
            this.txtPhone.Text = "   Phone *";
            this.txtPhone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickEnterTextBox);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneKeyPress);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.notNullPhone_Validating);
            // 
            // txtZip
            // 
            this.txtZip.BackColor = System.Drawing.SystemColors.Menu;
            this.txtZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtZip.Location = new System.Drawing.Point(453, 422);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(111, 26);
            this.txtZip.TabIndex = 3;
            this.txtZip.Tag = "   Zip Code *";
            this.txtZip.Text = "   Zip Code *";
            this.txtZip.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickEnterTextBox);
            this.txtZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zipCode_KeyPress);
            this.txtZip.Validating += new System.ComponentModel.CancelEventHandler(this.zipCodeNull_validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(231, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "* Fields marked with an asterisk are required.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Select Location";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtName.Location = new System.Drawing.Point(220, 382);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(347, 26);
            this.txtName.TabIndex = 3;
            this.txtName.Tag = "   Full Name *";
            this.txtName.Text = "   Full Name *";
            this.txtName.Visible = false;
            this.txtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickEnterTextBox);
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fullName_keyPress);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.fullName_validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(235, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "* Fields marked with an asterisk are required.";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(310, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbCity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "Limassol",
            "Nicosia",
            "Larnaca",
            "Paphos"});
            this.cmbCity.Location = new System.Drawing.Point(220, 379);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(344, 28);
            this.cmbCity.TabIndex = 8;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged_1);
            this.cmbCity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onMouseClickDropDown);
            this.cmbCity.Validating += new System.ComponentModel.CancelEventHandler(this.notNullComboBox_validating);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCity.Location = new System.Drawing.Point(223, 382);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(49, 20);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = " City *";
            this.lblCity.Click += new System.EventHandler(this.lblCity_Click);
            // 
            // cmbCityTakeAway
            // 
            this.cmbCityTakeAway.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbCityTakeAway.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCityTakeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbCityTakeAway.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbCityTakeAway.FormattingEnabled = true;
            this.cmbCityTakeAway.Items.AddRange(new object[] {
            "Limassol",
            "Nicosia",
            "Larnaca",
            "Paphos"});
            this.cmbCityTakeAway.Location = new System.Drawing.Point(220, 336);
            this.cmbCityTakeAway.Name = "cmbCityTakeAway";
            this.cmbCityTakeAway.Size = new System.Drawing.Size(348, 28);
            this.cmbCityTakeAway.TabIndex = 8;
            this.cmbCityTakeAway.Visible = false;
            this.cmbCityTakeAway.SelectedIndexChanged += new System.EventHandler(this.cmbCityTakeAway_SelectedIndexChanged);
            this.cmbCityTakeAway.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onMouseClickDropDown);
            this.cmbCityTakeAway.Validating += new System.ComponentModel.CancelEventHandler(this.cityTakeAway_Vallidating);
            // 
            // lblCityTakeAway
            // 
            this.lblCityTakeAway.AutoSize = true;
            this.lblCityTakeAway.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCityTakeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCityTakeAway.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCityTakeAway.Location = new System.Drawing.Point(234, 339);
            this.lblCityTakeAway.Name = "lblCityTakeAway";
            this.lblCityTakeAway.Size = new System.Drawing.Size(49, 20);
            this.lblCityTakeAway.TabIndex = 9;
            this.lblCityTakeAway.Text = " City *";
            this.lblCityTakeAway.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Delivery Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtPhoneTakeAway
            // 
            this.txtPhoneTakeAway.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPhoneTakeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneTakeAway.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPhoneTakeAway.Location = new System.Drawing.Point(220, 422);
            this.txtPhoneTakeAway.Name = "txtPhoneTakeAway";
            this.txtPhoneTakeAway.Size = new System.Drawing.Size(347, 26);
            this.txtPhoneTakeAway.TabIndex = 3;
            this.txtPhoneTakeAway.Tag = "   Phone *";
            this.txtPhoneTakeAway.Text = "   Phone *";
            this.txtPhoneTakeAway.Visible = false;
            this.txtPhoneTakeAway.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickEnterTextBox);
            this.txtPhoneTakeAway.TextChanged += new System.EventHandler(this.txtPhoneTakeAway_TextChanged);
            this.txtPhoneTakeAway.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTakeAway_KeyPress);
            this.txtPhoneTakeAway.Validating += new System.ComponentModel.CancelEventHandler(this.notNullPhoneTakeAway_Validating);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(437, -4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(349, 80);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-6, -4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(330, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(324, -10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(324, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReview.Location = new System.Drawing.Point(12, 738);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(99, 13);
            this.lblReview.TabIndex = 15;
            this.lblReview.Text = "Leave a Review";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContact.Location = new System.Drawing.Point(12, 716);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(70, 13);
            this.lblContact.TabIndex = 16;
            this.lblContact.Text = "Contact Us";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAbout.Location = new System.Drawing.Point(12, 691);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(59, 13);
            this.lblAbout.TabIndex = 17;
            this.lblAbout.Text = "About Us";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 680);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(786, 82);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblCityTakeAway);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPhoneTakeAway);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnTakeAway);
            this.Controls.Add(this.btnDelivery);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.cmbCityTakeAway);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrder";
            this.Text = "Start Order";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnTakeAway;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cmbCityTakeAway;
        private System.Windows.Forms.Label lblCityTakeAway;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtPhoneTakeAway;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

