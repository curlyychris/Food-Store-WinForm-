using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class Form7 : Form
    {

        CustomerDetails customerDetails;

        OrderManager orderManager;

        DiscountAndDeliveryDetails DiscountAndDeliveryDetails = new DiscountAndDeliveryDetails();

        public Form7(CustomerDetails customerDetails,OrderManager orderManager)
        {
            InitializeComponent();


            this.customerDetails = customerDetails;

            this.orderManager = orderManager;
        }

   

        private void button2_Click(object sender, EventArgs e)
        {

           
            if (WasACurrencyChoosen()==true)
            {
                if (txtBTC.Visible == true && txtBTC.Text.Trim().Length >0 || txtBTC.Visible == false )
                {
                    FormsManager.ChangeForm(6);
                }
                else
                {
                    MessageBox.Show("Bitcoin Address cannot be empty");

                }

            }
            else
            {
                MessageBox.Show("Choose a payment method","Payment Method",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormsManager.ChangeForm(1);
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
        }

      



        void SetFormDetails()
        {
            label2.Text = customerDetails.typeOfOrder;

            lblName.Text=customerDetails.nameOfOrder;

            lblAddress.Text=customerDetails.address;

            lblApt.Text=customerDetails.apartmentNumber;

            lblCity.Text=customerDetails.city;

            lblPhone.Text=customerDetails.telephoneNumber;

            lblZip.Text=customerDetails.zipCode;




        }

        void SetTheTotalAmountToPay()
        {
            float totalAmount = 0;

            for (int i = 0; i < orderManager.orders.Count; i++)
            {
                totalAmount += orderManager.orders[i].PriceOfOrder();
            }

            totalAmount -= totalAmount * DiscountAndDeliveryDetails.discountPercentage;

            totalAmount += DiscountAndDeliveryDetails.deliveryValue;

            TotalLbl.Text = "€" + Math.Round(totalAmount,2).ToString();
        }

        

       

        bool WasACurrencyChoosen()
        {
            if(CurrencyCmb.SelectedIndex!=-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void TotalLbl_Click(object sender, EventArgs e)
        {

        }

        private void CurrencyCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrencyCmb.Text == "Bitcoin")
            {
                label8.Visible = true;
                txtBTC.Visible = true;
            }
            else
            {
                label8.Visible = false;
                txtBTC.Visible = false;
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            SetTheTotalAmountToPay();

            SetFormDetails();
        }

        private void AddressOrName_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }

 
}
