using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        // Global Variables
        Store myStore = new Store();
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Create car");

            int intValue = 0;
            decimal decValue = 0.0m;
            var isValid = true;


            // Code challenge - Error Checking
            if (!Int32.TryParse(txt_Year.Text, out intValue))
            {
                isValid = false;
                MessageBox.Show($"Please enter a numeric value for field {lbl_Year.Text}"); 
            }

            if (!decimal.TryParse(txt_Price.Text, out decValue))
            {
                isValid = false;
                MessageBox.Show($"Please enter a numeric value for field {lbl_Price.Text}");

            }

            if (!txt_Color.Text.All(chr => char.IsLetter(chr)))
            {
                isValid = false;
                MessageBox.Show("Color field only allows Alphabetic characters");
            }

            // add car to inventory if fields are valid
            if (isValid == true)
            {

                Car car = new Car(txt_Make.Text, txt_Model.Text, txt_Color.Text, intValue, decValue);
             
                myStore.CarList.Add(car);
                carInventoryBindingSource.ResetBindings(false);
                // empty list after clicking button
                clearFields();
            
            }
        }

        private void btn_addToCart_Click(object sender, EventArgs e)
        {
            // get the selected item from inventory
            Car selected = (Car) lst_CarInventory.SelectedItem;

            // add that item to the cart
            myStore.ShoppingList.Add(selected);
          

            // update listbox control
            cartBindingSource.ResetBindings(false);
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            decimal total = myStore.Checkout();
            lbl_Total.Text = "$" + total.ToString();

            cartBindingSource.ResetBindings(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // bind data to controls
            carInventoryBindingSource.DataSource = myStore.CarList;
            cartBindingSource.DataSource = myStore.ShoppingList;

            lst_CarInventory.DataSource = carInventoryBindingSource;
            lst_CarInventory.DisplayMember = ToString();

            lst_ShoppingCart.DataSource = cartBindingSource;
            lst_ShoppingCart.DisplayMember = ToString();
        }

        // clear fields
        private void clearFields()
        {
            txt_Make.Text = String.Empty;
            txt_Model.Text = String.Empty;
            txt_Color.Text = String.Empty;
            txt_Year.Text = String.Empty;
            txt_Price.Text = String.Empty;
        }
    }
}
