using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    public class OrderDetails
    {


        protected string orderDetails;

        protected float priceOfOrder;

        protected float unitPrice;

        protected int quantity;


        public string DetailsOfOrder()
        {
            return orderDetails;
        }

        public void ChangesQuantity(int newValueOfQuantity)
        {
            quantity = newValueOfQuantity;
        }

        public float PriceOfOrder()
        {
            return priceOfOrder*quantity;
        }


        public float UnitPrice()
        {
            return unitPrice;
        }

        public int Quantity()
        {
            return quantity;
        }

       





    }
}
