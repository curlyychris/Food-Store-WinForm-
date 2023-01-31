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
    public partial class FormOrder : Form
    {

        CustomerDetails customerDetails;

        TextBox previousClickedTextBox;

        TextBox[] deliveryTextBoxes;

        TextBox[] takeAwayTextBoxes;

        Color defaultColor;
        Color defaultButtonColor;

        public FormOrder(CustomerDetails customerDetails)
        {
            this.customerDetails = customerDetails;

            InitializeComponent();

            defaultColor=txtZip.BackColor;
            defaultButtonColor=btnTakeAway.BackColor;

            SetTheDeliveryAndTakeAwayTextBoxes();
            //only allows 4 digits into the textbox
            txtZip.MaxLength=4;
            //only allows 8 digits into the textbox (Cyprus phone numbers have 8 digits)
            txtPhone.MaxLength=8;
            textBox1.MaxLength=6;
            txtPhoneTakeAway.MaxLength=8;
        }

        void SetTheDeliveryAndTakeAwayTextBoxes()
        {
            deliveryTextBoxes = new TextBox[] {txtAddress,txtPhone,txtZip};

            takeAwayTextBoxes = new TextBox[] { txtName };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            txtAddress.Visible = false;
            textBox1.Visible = false;
            cmbCity.Visible = false;
            lblCity.Visible=false;
            txtPhone.Visible = false;
            txtZip.Visible = false;
            label3.Visible = false;
            label4.Visible = true;
            cmbCityTakeAway.Visible = true;
            txtName.Visible = true;
            label5.Visible = true;
            lblCityTakeAway.Visible=true;
            txtPhoneTakeAway.Visible=true;
            btnDelivery.BackColor=defaultButtonColor;
            btnTakeAway.BackColor=Color.FromArgb(195, 239, 236);
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            cmbCityTakeAway.Visible = false;
            txtName.Visible = false;
            label5.Visible = false;
            cmbCityTakeAway.Visible=false;
            lblCityTakeAway.Visible=false;
            txtPhoneTakeAway.Visible=false;
            label2.Visible = true;
            txtAddress.Visible = true;
            textBox1.Visible = true;
            cmbCity.Visible = true;
            txtPhone.Visible = true;
            txtZip.Visible = true;
            label3.Visible = true;
            lblCity.Visible=true;
            btnDelivery.BackColor=Color.FromArgb(195, 239, 236);
            btnTakeAway.BackColor=defaultButtonColor;

        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
             customerDetails.typeOfOrder = btnDelivery.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(AreTheDataValid()==true)
            {

                if(customerDetails.typeOfOrder=="Delivery")
                {
                    customerDetails.telephoneNumber = "Phone: "+txtPhone.Text;
                    customerDetails.address ="Address: "+txtAddress.Text;
                    
                    customerDetails.apartmentNumber=textBox1.Text!=textBox1.Tag.ToString()? "Apt. #: "+ textBox1.Text:"";
                    customerDetails.zipCode="Zip Code: "+ txtZip.Text;
                    customerDetails.city="City: "+cmbCity.SelectedItem;

                    customerDetails.nameOfOrder="";
                }
                else
                {
                    customerDetails.telephoneNumber = "Phone: "+ txtPhoneTakeAway.Text;
                    customerDetails.nameOfOrder = "Name: "+txtName.Text;
                    customerDetails.city="City: "+cmbCityTakeAway.SelectedItem;

                    customerDetails.address ="";
                    customerDetails.apartmentNumber="";
                    customerDetails.zipCode="";
                }

                FormsManager.ChangeForm(1);
            } 
        }
  
        private void OnClickButton(object sender, MouseEventArgs e)
        {
            customerDetails.typeOfOrder = ((Button)sender).Text;
        }

        bool AreTheDataValid()
        {

            try
            {
                if (customerDetails.typeOfOrder == "Delivery")
                {
                    foreach(TextBox deliveryTextBox in deliveryTextBoxes)
                    {
                        if(deliveryTextBox.Text.Trim()=="" || deliveryTextBox.Text== deliveryTextBox.Tag.ToString())
                        {
                            MessageBox.Show("Please enter your information","Missing Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;

                        }
                    }

                   if(textBox1.Text!= textBox1.Tag.ToString() )
                    {
                        int.Parse(textBox1.Text);
                    }

                   if(txtPhone.Text.Length!=8)
                    {
                        return false;
                    }

                   if(txtZip.Text.Length!=4)
                   {
                        return false;
                   }

                  if(cmbCity.SelectedItem == null)
                  {
                      return false;
                  }

                  

                    int.Parse(txtPhone.Text);

                    int.Parse(txtZip.Text);
                }
                else
                {
                    foreach (TextBox takeAwayTextBox in takeAwayTextBoxes)
                    {
                        if (takeAwayTextBox.Text.Trim() == "" || takeAwayTextBox.Text == takeAwayTextBox.Tag.ToString())
                        {
                            MessageBox.Show("Please enter your information","Missing Information",MessageBoxButtons.OK, MessageBoxIcon.Information);

                            return false;

                        }
                    }

                    if(txtPhoneTakeAway.Text.Length!=8)
                    {
                      return false;
                    }
                    if(cmbCityTakeAway.SelectedItem == null)
                    {
                      return false;
                    }
                }


                return true;

            }
            catch
            {
                MessageBox.Show("Invalid data");

                return false;

            }

           
        }

        private void OnClickEnterTextBox(object sender, MouseEventArgs e)
        {
            if (previousClickedTextBox != null)
            {
                SetTheDefualtTextBoxValues(previousClickedTextBox);
            }

            previousClickedTextBox = ((TextBox)sender);

            RemoveDefualtText((TextBox) sender);
        }

        void RemoveDefualtText(TextBox textBox)
        {
            if(textBox.Text== textBox.Tag.ToString())
            {
                textBox.Text = "";

            }
        }

       

        void SetTheDefualtTextBoxValues(TextBox textBox)
        {
            if(textBox.Text== textBox.Tag.ToString() || textBox.Text.Trim()=="")
            {
                textBox.Text = textBox.Tag.ToString();

            }
        }

        private void cmbCityTakeAway_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if any item is selected selected index will be greater than -1
            if(cmbCityTakeAway.SelectedIndex>-1)
            {
                lblCityTakeAway.Text="";
            }
        }

        private void cmbCity_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //if any item is selected selected index will be greater than -1
            if(cmbCity.SelectedIndex>-1)
            {
                lblCity.Text="";
            }
        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void onMouseClickDropDown(object sender, MouseEventArgs e)
        {
            if(previousClickedTextBox!=null)
            {
                SetTheDefualtTextBoxValues(previousClickedTextBox);
                previousClickedTextBox=null;
            }
        }

        private void notNull_validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtAddress.Text))
            {
                errorProvider1.SetError(txtAddress,"Please enter your address");
                txtAddress.BackColor=Color.FromArgb(253, 144, 144);
            }
            else
            {
                errorProvider1.Clear();
                txtAddress.BackColor=defaultColor;
            }

        }
        //makes sure that one of the options in the comboBox is selected
        private void notNullComboBox_validating(object sender, CancelEventArgs e)
        {
            if(cmbCity.SelectedItem==null)
            {
                errorProvider1.SetError(cmbCity,"Please select a city");
                cmbCity.BackColor=Color.FromArgb(253, 144, 144);
            }
            else
            {
                errorProvider1.Clear();
                cmbCity.BackColor=defaultColor;
            }
        }

     
        //makes sure only digits are pressed
        private void aptNo_keyPress(object sender, KeyPressEventArgs e)
        {
             if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
             {
                e.Handled=true;
             }
        }
        //makes sure user enters something (field is not null)
        private void zipCodeNull_validating(object sender, CancelEventArgs e)
        {
             if(string.IsNullOrEmpty(txtZip.Text))
             {
                errorProvider1.SetError(txtZip,"Please enter your 4 digit zip code");
                txtZip.BackColor=Color.FromArgb(253, 144, 144);
             }
            else
            {
                errorProvider1.Clear();
                txtZip.BackColor=defaultColor;
            }
             if(txtZip.Text.Length<4)
             {
                errorProvider1.SetError(txtZip,"Please enter your 4 digit zip code");
                txtZip.BackColor=Color.FromArgb(253, 144, 144);
             }
             else
             {
               errorProvider1.Clear();
               txtZip.BackColor=defaultColor;
             }
        }
        //makes sure only digits are pressed
        private void zipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
             if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
             {
                e.Handled=true;
             }
        }
        //makes sure that the phone is not null and has 8 numbers entered
        private void notNullPhone_Validating(object sender, CancelEventArgs e)
        {
             if(string.IsNullOrEmpty(txtPhone.Text))
             {
                errorProvider1.SetError(txtPhone,"Please enter your 8 digit Cypriot phone number");
                txtPhone.BackColor=Color.FromArgb(253, 144, 144);
             }
            else
            {
                errorProvider1.Clear();
                txtPhone.BackColor=defaultColor;
            }
             if(txtPhone.Text.Length<8)
             {
                errorProvider1.SetError(txtPhone,"Please enter your 8 digit Cypriot phone number");
                txtPhone.BackColor=Color.FromArgb(253, 144, 144);
             }
             else
             {
               errorProvider1.Clear();
                txtPhone.BackColor=defaultColor;
             }
        }

        //only allows numbers for phone field
        private void phoneKeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled=true;
            }
        }

        //only allows letters and spaces for the full name
        private void fullName_keyPress(object sender, KeyPressEventArgs e)
        {
            char ch=e.KeyChar;
            //key enumeration, 32 stands for the space bar
             if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)&&ch!=32)
             {
                e.Handled=true;
             }
        }

        //makes sure the name is not empty
        private void fullName_validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.SetError(txtName,"Please enter your full name");
              txtName.BackColor=Color.FromArgb(253, 144, 144);
            }
            else
            {
                errorProvider1.Clear();
                txtName.BackColor=defaultColor;
            }
        }

        //makes sure that one of the options in the comboBox is selected
        private void cityTakeAway_Vallidating(object sender, CancelEventArgs e)
        {
             if(cmbCityTakeAway.SelectedItem==null)
             {
                errorProvider1.SetError(cmbCityTakeAway,"Please select a city");
                cmbCityTakeAway.BackColor=Color.FromArgb(253, 144, 144);
             }
            else
            {
                errorProvider1.Clear();
                cmbCityTakeAway.BackColor=defaultColor;
            }
        }

        private void notNullPhoneTakeAway_Validating(object sender, CancelEventArgs e)
        {
             if(string.IsNullOrEmpty(txtPhoneTakeAway.Text))
             {
                errorProvider1.SetError(txtPhoneTakeAway,"Please enter your 8 digit Cypriot phone number");
                txtPhoneTakeAway.BackColor=Color.FromArgb(253, 144, 144);
             }
            else
            {
                errorProvider1.Clear();
                txtPhoneTakeAway.BackColor=defaultColor;
            }
             if(txtPhoneTakeAway.Text.Length<8)
             {
                errorProvider1.SetError(txtPhoneTakeAway,"Please enter your 8 digit Cypriot phone number");
                txtPhoneTakeAway.BackColor=Color.FromArgb(253, 144, 144);
             }
             else
             {
               errorProvider1.Clear();
                txtPhoneTakeAway.BackColor=defaultColor;
             }
        }

        private void phoneTakeAway_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled=true;
            }
        }

        private void txtPhoneTakeAway_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
