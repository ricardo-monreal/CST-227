
namespace CarShopGUI
{
    partial class Form1
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
            this.gb_CreateCar = new System.Windows.Forms.GroupBox();
            this.btn_CreateCar = new System.Windows.Forms.Button();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.txt_Make = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.lbl_Make = new System.Windows.Forms.Label();
            this.gb_CarInventory = new System.Windows.Forms.GroupBox();
            this.lst_CarInventory = new System.Windows.Forms.ListBox();
            this.gb_ShoppingCart = new System.Windows.Forms.GroupBox();
            this.lst_ShoppingCart = new System.Windows.Forms.ListBox();
            this.btn_addToCart = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.gb_CreateCar.SuspendLayout();
            this.gb_CarInventory.SuspendLayout();
            this.gb_ShoppingCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_CreateCar
            // 
            this.gb_CreateCar.Controls.Add(this.txt_Year);
            this.gb_CreateCar.Controls.Add(this.lbl_Year);
            this.gb_CreateCar.Controls.Add(this.txt_Color);
            this.gb_CreateCar.Controls.Add(this.lbl_Color);
            this.gb_CreateCar.Controls.Add(this.btn_CreateCar);
            this.gb_CreateCar.Controls.Add(this.txt_Price);
            this.gb_CreateCar.Controls.Add(this.txt_Model);
            this.gb_CreateCar.Controls.Add(this.txt_Make);
            this.gb_CreateCar.Controls.Add(this.lbl_Price);
            this.gb_CreateCar.Controls.Add(this.lbl_Model);
            this.gb_CreateCar.Controls.Add(this.lbl_Make);
            this.gb_CreateCar.Location = new System.Drawing.Point(18, 82);
            this.gb_CreateCar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_CreateCar.Name = "gb_CreateCar";
            this.gb_CreateCar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_CreateCar.Size = new System.Drawing.Size(318, 382);
            this.gb_CreateCar.TabIndex = 0;
            this.gb_CreateCar.TabStop = false;
            this.gb_CreateCar.Text = "Create a Car: ";
            // 
            // btn_CreateCar
            // 
            this.btn_CreateCar.Location = new System.Drawing.Point(186, 319);
            this.btn_CreateCar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CreateCar.Name = "btn_CreateCar";
            this.btn_CreateCar.Size = new System.Drawing.Size(112, 35);
            this.btn_CreateCar.TabIndex = 8;
            this.btn_CreateCar.Text = "Create Car";
            this.btn_CreateCar.UseVisualStyleBackColor = true;
            this.btn_CreateCar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(88, 263);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(210, 26);
            this.txt_Price.TabIndex = 7;
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(88, 108);
            this.txt_Model.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(210, 26);
            this.txt_Model.TabIndex = 4;
            // 
            // txt_Make
            // 
            this.txt_Make.Location = new System.Drawing.Point(88, 60);
            this.txt_Make.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Make.Name = "txt_Make";
            this.txt_Make.Size = new System.Drawing.Size(210, 26);
            this.txt_Make.TabIndex = 3;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(9, 266);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(48, 20);
            this.lbl_Price.TabIndex = 2;
            this.lbl_Price.Text = "Price:";
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Location = new System.Drawing.Point(9, 112);
            this.lbl_Model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(56, 20);
            this.lbl_Model.TabIndex = 1;
            this.lbl_Model.Text = "Model:";
            // 
            // lbl_Make
            // 
            this.lbl_Make.AutoSize = true;
            this.lbl_Make.Location = new System.Drawing.Point(9, 60);
            this.lbl_Make.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Make.Name = "lbl_Make";
            this.lbl_Make.Size = new System.Drawing.Size(52, 20);
            this.lbl_Make.TabIndex = 0;
            this.lbl_Make.Text = "Make:";
            this.lbl_Make.Click += new System.EventHandler(this.label1_Click);
            // 
            // gb_CarInventory
            // 
            this.gb_CarInventory.Controls.Add(this.lst_CarInventory);
            this.gb_CarInventory.Location = new System.Drawing.Point(344, 82);
            this.gb_CarInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_CarInventory.Name = "gb_CarInventory";
            this.gb_CarInventory.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_CarInventory.Size = new System.Drawing.Size(401, 466);
            this.gb_CarInventory.TabIndex = 1;
            this.gb_CarInventory.TabStop = false;
            this.gb_CarInventory.Text = "Car Inventory";
            // 
            // lst_CarInventory
            // 
            this.lst_CarInventory.FormattingEnabled = true;
            this.lst_CarInventory.ItemHeight = 20;
            this.lst_CarInventory.Location = new System.Drawing.Point(9, 31);
            this.lst_CarInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_CarInventory.Name = "lst_CarInventory";
            this.lst_CarInventory.Size = new System.Drawing.Size(384, 424);
            this.lst_CarInventory.TabIndex = 0;
            // 
            // gb_ShoppingCart
            // 
            this.gb_ShoppingCart.Controls.Add(this.lst_ShoppingCart);
            this.gb_ShoppingCart.Location = new System.Drawing.Point(779, 82);
            this.gb_ShoppingCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_ShoppingCart.Name = "gb_ShoppingCart";
            this.gb_ShoppingCart.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_ShoppingCart.Size = new System.Drawing.Size(367, 232);
            this.gb_ShoppingCart.TabIndex = 2;
            this.gb_ShoppingCart.TabStop = false;
            this.gb_ShoppingCart.Text = "Shopping Cart";
            // 
            // lst_ShoppingCart
            // 
            this.lst_ShoppingCart.FormattingEnabled = true;
            this.lst_ShoppingCart.ItemHeight = 20;
            this.lst_ShoppingCart.Location = new System.Drawing.Point(9, 31);
            this.lst_ShoppingCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_ShoppingCart.Name = "lst_ShoppingCart";
            this.lst_ShoppingCart.Size = new System.Drawing.Size(358, 184);
            this.lst_ShoppingCart.TabIndex = 0;
            // 
            // btn_addToCart
            // 
            this.btn_addToCart.Location = new System.Drawing.Point(633, 557);
            this.btn_addToCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_addToCart.Name = "btn_addToCart";
            this.btn_addToCart.Size = new System.Drawing.Size(112, 35);
            this.btn_addToCart.TabIndex = 3;
            this.btn_addToCart.Text = "Add to Cart";
            this.btn_addToCart.UseVisualStyleBackColor = true;
            this.btn_addToCart.Click += new System.EventHandler(this.btn_addToCart_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(1034, 348);
            this.btn_checkout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(112, 35);
            this.btn_checkout.TabIndex = 4;
            this.btn_checkout.Text = "Checkout";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(840, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Cost: ";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(942, 323);
            this.lbl_Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(49, 20);
            this.lbl_Total.TabIndex = 6;
            this.lbl_Total.Text = "$0.00";
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Location = new System.Drawing.Point(9, 166);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(46, 20);
            this.lbl_Color.TabIndex = 7;
            this.lbl_Color.Text = "Color";
            // 
            // txt_Color
            // 
            this.txt_Color.Location = new System.Drawing.Point(88, 163);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(210, 26);
            this.txt_Color.TabIndex = 5;
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Location = new System.Drawing.Point(9, 215);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(47, 20);
            this.lbl_Year.TabIndex = 9;
            this.lbl_Year.Text = "Year:";
            // 
            // txt_Year
            // 
            this.txt_Year.Location = new System.Drawing.Point(88, 212);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(210, 26);
            this.txt_Year.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1267, 706);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.btn_addToCart);
            this.Controls.Add(this.gb_ShoppingCart);
            this.Controls.Add(this.gb_CarInventory);
            this.Controls.Add(this.gb_CreateCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "CST-227 Activity 1 - Car Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_CreateCar.ResumeLayout(false);
            this.gb_CreateCar.PerformLayout();
            this.gb_CarInventory.ResumeLayout(false);
            this.gb_ShoppingCart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_CreateCar;
        private System.Windows.Forms.Label lbl_Make;
        private System.Windows.Forms.Button btn_CreateCar;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.TextBox txt_Make;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.GroupBox gb_CarInventory;
        private System.Windows.Forms.GroupBox gb_ShoppingCart;
        private System.Windows.Forms.ListBox lst_CarInventory;
        private System.Windows.Forms.ListBox lst_ShoppingCart;
        private System.Windows.Forms.Button btn_addToCart;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txt_Year;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.TextBox txt_Color;
        private System.Windows.Forms.Label lbl_Color;
    }
}

