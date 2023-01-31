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
    public partial class Form6 : Form
    {
        CustomerDetails customerDetails;
        
        OrderManager orderManager;

        OrderDetails currentOrder;

        DiscountAndDeliveryDetails discountAndDeliveryDetails = new DiscountAndDeliveryDetails();

        Dictionary<NumericUpDown, OrderDetails> numericUpDownAndOrderDetails = new Dictionary<NumericUpDown, OrderDetails>();


        float heightOfRow;

        delegate void OnValueChangeNumericUpDown(object sender, EventArgs e);

        OnValueChangeNumericUpDown onValueChangeNumericUp;

        public Form6(OrderManager orderManager, CustomerDetails customerDetails)
        {

            this.customerDetails=customerDetails;

            this.orderManager = orderManager;

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(orderManager.orders.Count>0)
            {
                FormsManager.ChangeForm(4);

            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormsManager.ChangeForm(1);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OnFormActivate(object sender, EventArgs e)
        {

            RemoveAllRows();

        }


        void GetOrderDetails()
        {
            

            for (int i = 0; i < orderManager.orders.Count; i++)
            {

                currentOrder = orderManager.orders[i];

                AddRows(new Label[] {

                LabelCreated(orderManager.orders[i].DetailsOfOrder()),
                LabelCreated(orderManager.orders[i].Quantity().ToString()),
                LabelCreated(orderManager.orders[i].UnitPrice().ToString()),
                LabelCreated(orderManager.orders[i].PriceOfOrder().ToString()),



            });

  
            }

            CalculateTheSubTotal();



        }


        void CalculateTheSubTotal()
        {
            double subTotal = 0;

            for (int i = 0; i < orderManager.orders.Count; i++)
            {

                subTotal += orderManager.orders[i].PriceOfOrder();

            }

            DisplaySubtotal(subTotal);

            CalculateTheEstimatedTotalAndDiscount(subTotal);
        }

        Label LabelCreated (string labelText)
        {
            Label labelClone = new Label();

            labelClone.AutoSize = true;

            labelClone.Padding = new Padding(0, 0, 0, 100);

            //labelClone.Text = "works";

            labelClone.Text = labelText;

            //tableLayoutPanel1.Controls.Add(labelClone);

            return labelClone;




        }

        

        void DisplaySubtotal(double amountToAdd)
        {

            lblSubtotal.Text =  "€"+ Math.Round(amountToAdd,2).ToString();
        }

        void CalculateTheEstimatedTotalAndDiscount(double subtotal)
        {

            double discount = (subtotal * discountAndDeliveryDetails.discountPercentage);

            double deliveryCost=customerDetails.typeOfOrder=="Delivery"?discountAndDeliveryDetails.deliveryValue:0;

            lblDiscount.Text = "€"+Math.Round(discount,2).ToString();

            lblDelivery.Text = "€" + deliveryCost.ToString();

            label10.Text = "€" + Math.Round((subtotal + discountAndDeliveryDetails.deliveryValue - discount),2).ToString();
            
        }

        void RemoveAllRows()
        {

            GetSizeOfRow();

            numericUpDownAndOrderDetails.Clear();

            for (int i=0; i< tableLayoutPanel1.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                {
                    Control control = tableLayoutPanel1.GetControlFromPosition(j, i);

                    //MessageBox.Show(control.Name);

                    tableLayoutPanel1.Controls.Remove(control);
                }
            }

            while(tableLayoutPanel1.RowCount>0)
            {
                tableLayoutPanel1.RowCount--;

                tableLayoutPanel1.RowStyles.RemoveAt(tableLayoutPanel1.RowCount);


                
            }

           

           GetOrderDetails();

        }

        void AddRows(Label[] labelsToAdd)
        {


            tableLayoutPanel1.RowCount++;

            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize, heightOfRow));


            for (int i=0; i< labelsToAdd.Length; i++)
            {
                if(i!=1)
                {
                    tableLayoutPanel1.Controls.Add(labelsToAdd[i], i, tableLayoutPanel1.RowCount - 1);
                }
                else
                {
                    tableLayoutPanel1.Controls.Add(QuanityChangerButtonToSpawn()
                        , i, tableLayoutPanel1.RowCount - 1);
                }

                //tableLayoutPanel1.Controls.Add(labelsToAdd[i]);

            }






        }

        private void OnMouseClixk(object sender, EventArgs e)
        {
            //GetOrderDetails();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            //RemoveAllRows();
        }

        void GetSizeOfRow()
        {
            if(heightOfRow == 0)
            {

                heightOfRow = tableLayoutPanel1.RowStyles[0].Height;
            }
            
        }

        void OnNumericUpDownValueChange(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;


            ChangeTheQuanityOfItems(numericUpDown);


        }

        void ChangeTheQuanityOfItems(NumericUpDown numericUpDown)
        {
            if(numericUpDownAndOrderDetails.ContainsKey(numericUpDown)==true)
            {
                 numericUpDownAndOrderDetails[numericUpDown].
                 ChangesQuantity((int)numericUpDown.Value);

                 DisplayDeletionWarningMessage(numericUpDownAndOrderDetails[numericUpDown]);

                 CalculateTheSubTotal();
            }
           
        }

        void DisplayDeletionWarningMessage(OrderDetails orderDetails)
        {
            if(orderDetails.Quantity()==0)
            {
                 if (MessageBox.Show("Do you want to delete this item","Delete warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                 {
                     //RemoveOrderFromTable(orderDetails);
                     orderManager.orders.Remove(orderDetails);
                 }
                 else
                 {
                     orderDetails.ChangesQuantity(1);
                 }

            }

            RemoveAllRows();
        }

        void RemoveOrderFromTable(OrderDetails orderDetails)
        {
            for(int i=0; i<orderManager.orders.Count; i++)
            {
                if(orderManager.orders[i]== orderDetails)
                {
                    for(int j=0; j<tableLayoutPanel1.ColumnCount; j++)
                    {
                        Control control = tableLayoutPanel1.GetControlFromPosition(j, i);

                        tableLayoutPanel1.Controls.Remove(control);
                    }

                    tableLayoutPanel1.RowStyles.RemoveAt(i);

                    tableLayoutPanel1.RowCount--;

                    break;
                }
            }
        }



        NumericUpDown QuanityChangerButtonToSpawn()
        {
            NumericUpDown numericUpDown = new NumericUpDown();

            numericUpDownAndOrderDetails.Add(numericUpDown, currentOrder);

            numericUpDown.Value = currentOrder.Quantity();

            numericUpDown.ValueChanged += OnNumericUpDownValueChange;

            return numericUpDown;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblDelivery_Click(object sender, EventArgs e)
        {

        }
    }






}
