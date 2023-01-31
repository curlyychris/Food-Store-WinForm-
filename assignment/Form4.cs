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
    public partial class Form4 : Form
    {

        OrderManager orderManager;

        Dictionary<NumericUpDown, Label> quantityAndNameOfItem = new Dictionary<NumericUpDown, Label>();

        public Form4(OrderManager orderManager)
        {
            InitializeComponent();

            this.orderManager = orderManager;

            GetNameAndQauntityOfItems();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void GetNameAndQauntityOfItems()
        {
            quantityAndNameOfItem.Add(QuantityNud1, ItemName1);
            quantityAndNameOfItem.Add(QuantityNud2, ItemName2);
            quantityAndNameOfItem.Add(QuantityNud3, ItemName3);
            quantityAndNameOfItem.Add(QuantityNud4, ItemName4);
            quantityAndNameOfItem.Add(QuantityNud5, ItemName5);
            quantityAndNameOfItem.Add(QuantityNud6, ItemName6);
            quantityAndNameOfItem.Add(QuantityNud7, ItemName7);
            quantityAndNameOfItem.Add(QuantityNud8, ItemName8);
            quantityAndNameOfItem.Add(QuantityNud9, ItemName9);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CollectUserChoiceDetails();


            ResetUsersChoices();

            FormsManager.ChangeForm(1);
            

        }

        void CollectUserChoiceDetails()
        {
            


            foreach (NumericUpDown quanityButton in quantityAndNameOfItem.Keys)
            {
                if (quanityButton.Value > 0)
                {
                    
                    PresetOrderDetails presetOrderDetails = new PresetOrderDetails();

                    presetOrderDetails.ExtractOrderInformation(quantityAndNameOfItem[quanityButton].Text
                        , (int)quanityButton.Value, float.Parse(quanityButton.Tag.ToString()));


                    if (orderManager.DoesTheOrderExist(presetOrderDetails, presetOrderDetails.Quantity())==false)
                    {
                        orderManager.orders.Add(presetOrderDetails);
                    }
                        
                }
            }

            /* if(nameAndQuanity.Count>0)
             {
                 presetOrderDetails.ExtractOrderInformation(nameAndQuanity, priceOfItems);

                 orderManager.orders.Add(presetOrderDetails);
             }*/



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ResetUsersChoices();

            FormsManager.ChangeForm(1);

        }


        void ResetUsersChoices()
        {
            foreach(NumericUpDown numericUpDown in quantityAndNameOfItem.Keys)
            {
                numericUpDown.Value = 0;
            }
        }
    }
}
