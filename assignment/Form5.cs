using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class Form5 : Form
    {

        Dictionary<Button, CheckedListBox> buttonsAndCheckBoxs = new Dictionary<Button, CheckedListBox>();

        CheckedListBox currentlySelectedCheckBoxList;

        bool canTheValuesChange =true;

        OrderManager orderManager;

        public Form5(OrderManager orderManager)
        {
            InitializeComponent();

            this.orderManager = orderManager;

            SetTheButtonsAndCheckListBoxs();

            
        }



        private void Form2_Load(object sender, EventArgs e)
        {
        }



        void SetTheButtonsAndCheckListBoxs()
        {
            

            buttonsAndCheckBoxs.Add(OptionButton1, optionsClb1);
            buttonsAndCheckBoxs.Add(OptionButton2, optionsClb2);
            buttonsAndCheckBoxs.Add(OptionButton3, optionsClb3);
            buttonsAndCheckBoxs.Add(OptionButton4, optionsClb4);
            buttonsAndCheckBoxs.Add(OptionButton5, optionsClb5);
            buttonsAndCheckBoxs.Add(OptionButton6, optionsClb6);

            SetDefaultValuesForCheckListBoxes(buttonsAndCheckBoxs[OptionButton1],0);

            SetDefaultValuesForCheckListBoxes(buttonsAndCheckBoxs[OptionButton5],0);

        }

        void DisplayTheOptionsMenu(Button optionButtonClicked)
        {

            currentlySelectedCheckBoxList = (buttonsAndCheckBoxs[optionButtonClicked]);

            currentlySelectedCheckBoxList.Visible = !currentlySelectedCheckBoxList.Visible;

            
        }

        private void OptionsButtonClick(object sender, MouseEventArgs e)
        {
            DisplayTheOptionsMenu((Button)sender);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            CreateYourOwnOrderDetails createYourOwnOrderDetails = new CreateYourOwnOrderDetails();

            createYourOwnOrderDetails.ExtractItemsInformation(GetCheckItems(),int.Parse(lblQuantity.Text));

            if(orderManager.DoesTheOrderExist(createYourOwnOrderDetails,createYourOwnOrderDetails.Quantity()) ==false)
            {
                orderManager.orders.Add(createYourOwnOrderDetails);

            }


            ResetTheUserSelections();

            FormsManager.ChangeForm(1);

        }



        void SetDefaultValuesForCheckListBoxes(CheckedListBox checkedListBox,int defualtIndex)
        {
            checkedListBox.SetItemChecked(defualtIndex, true);

        }

        private void OnItemChecked(object sender, ItemCheckEventArgs e)
        {


            if(e.NewValue==CheckState.Checked)
            {


                UnCheckPreviousSelections((CheckedListBox)sender);

                canTheValuesChange = true;
            }
            else if(e.CurrentValue==CheckState.Checked && canTheValuesChange==true)
            {
                e.NewValue = e.CurrentValue;
            }
                

        }

        void UnCheckPreviousSelections(CheckedListBox checkedListBox)
        {
            canTheValuesChange = false;

            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);

            }
        }

        List<string> GetCheckItems()
        {
            List<string> checkedItems = new List<string>();

            foreach(CheckedListBox checkedListBox in buttonsAndCheckBoxs.Values)
            {
                foreach (string selectedItems in checkedListBox.CheckedItems)
                {
                    checkedItems.Add(selectedItems);
                }
            }

            return checkedItems;
        }


    

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            ResetTheUserSelections();

            FormsManager.ChangeForm(1);

        }
        private int iCount = 0;
        private void btnMinus_Click(object sender, EventArgs e)
        {
            iCount = iCount - 1;
            
            if(iCount<1)
            {
                iCount = 1;
            }
            lblQuantity.Text = iCount.ToString();
            //add quantity to order

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            iCount = iCount + 1;
            lblQuantity.Text = iCount.ToString();
        }

        private void optionsClb2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void ResetTheUserSelections()
        {
            foreach(CheckedListBox checkedListBox in buttonsAndCheckBoxs.Values)
            {
                for(int i=0; i< checkedListBox.Items.Count; i++)
                {
                    checkedListBox.SetItemChecked(i, false);

                }

                checkedListBox.Visible = false;
            }

            lblQuantity.Text = "1";
            iCount=1;
        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }
    }

}
