using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;



namespace assignment
{
    public static class FormsManager
    {
        static OrderManager orderManager = new OrderManager();

        static CustomerDetails customerDetails = new CustomerDetails();

        static int previousFormIndex;

        static Form[] forms = new Form[] {
            new FormOrder(customerDetails),
            new FormChooseOrMake(orderManager),
            new Form5(orderManager),
            new Form4(orderManager),
            new Form7(customerDetails,orderManager),
            new Form6(orderManager,customerDetails),
            new Form3(orderManager),



        };

        static public void ChangeForm(int formIndex)
        {
   
            forms[formIndex].Show();

            forms[previousFormIndex].Hide();

            previousFormIndex = formIndex;
        }

        static public void StartTheFirstForm(int formIndex)
        {
            Application.Run(forms[formIndex]);

            previousFormIndex = formIndex;
        }

        public static Form[] Forms()
        {
            return forms;
        }


    }
}