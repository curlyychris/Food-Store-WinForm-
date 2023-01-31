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
    public partial class FormChooseOrMake : Form
    {
        OrderManager orderManager;

        public FormChooseOrMake(OrderManager orderManager)
        {

            this.orderManager = orderManager;

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormsManager.ChangeForm(2);
        }

        private void FormChooseOrMake_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormsManager.ChangeForm(3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormsManager.ChangeForm(0);
        }

        private void Cart_Click(object sender, EventArgs e)
        {
            FormsManager.ChangeForm(5);
        }

      

        void SetTheCartAmountOfItems()
        {
            int amountOfItems = 0;

            foreach(OrderDetails orderDetails in orderManager.orders)
            {
                amountOfItems += orderDetails.Quantity();
            }

            ChartItemsAmountLbl.Text = amountOfItems.ToString();
        }

        private void OnFormActivate(object sender, EventArgs e)
        {
            SetTheCartAmountOfItems();
        }
    }
}
