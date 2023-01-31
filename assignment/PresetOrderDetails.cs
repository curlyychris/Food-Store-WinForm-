using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class PresetOrderDetails:OrderDetails
    {

        public void ExtractOrderInformation(string nameOfItem,int quantity,float priceOfItems)
        {
            int numberOfOrder = 0;

            string detailsOfOrder;

            //detailsOfOrder = nameOfItem + " " + priceOfItems+"€"
            //+ "(x" + quantity + ")\n";

            detailsOfOrder = nameOfItem + " " + "€" + priceOfItems;
    
            unitPrice += priceOfItems;

            priceOfOrder = priceOfItems;

            this.quantity = quantity;

            orderDetails =detailsOfOrder;

            numberOfOrder++;
            
        }

    }
}
