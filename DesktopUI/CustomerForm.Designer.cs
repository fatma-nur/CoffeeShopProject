
namespace DesktopUI
{
    partial class CustomerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCoffeeShop = new System.Windows.Forms.ComboBox();
            this.lblShopName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cmbCoffeeShop
            // 
            this.cmbCoffeeShop.FormattingEnabled = true;
            this.cmbCoffeeShop.Location = new System.Drawing.Point(114, 52);
            this.cmbCoffeeShop.Name = "cmbCoffeeShop";
            this.cmbCoffeeShop.Size = new System.Drawing.Size(121, 23);
            this.cmbCoffeeShop.TabIndex = 1;
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = true;
            this.lblShopName.Location = new System.Drawing.Point(12, 60);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(85, 15);
            this.lblShopName.TabIndex = 2;
            this.lblShopName.Text = "Kahve Dükkanı";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 87);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(22, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Ad";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 4;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(13, 144);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(39, 15);
            this.lblTC.TabIndex = 5;
            this.lblTC.Text = "TC No";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(114, 141);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 23);
            this.txtTC.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(114, 218);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 39);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Kaydet";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Location = new System.Drawing.Point(13, 179);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(57, 15);
            this.lblBirthYear.TabIndex = 8;
            this.lblBirthYear.Text = "Birth Year";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(13, 112);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(39, 15);
            this.lblSurname.TabIndex = 10;
            this.lblSurname.Text = "Soyad";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(114, 112);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 23);
            this.txtSurname.TabIndex = 11;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(114, 173);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(111, 23);
            this.dtpBirthdate.TabIndex = 12;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 331);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblBirthYear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblShopName);
            this.Controls.Add(this.cmbCoffeeShop);
            this.Name = "CustomerForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCoffeeShop;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
    }
}

