using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class CreateYourOwnOrderDetails : OrderDetails
    {


        public void ExtractItemsInformation(List<string> nameAndPriceOfItem,int quantity)
        {

            string[] nameAndPriceSplit;

            string detailsOfOrder;

            detailsOfOrder = "Create you own"+"\n";

            for(int i=0; i< nameAndPriceOfItem.Count; i++)
            {
                nameAndPriceSplit = nameAndPriceOfItem[i].Split(':');

                detailsOfOrder += nameAndPriceSplit[0].Trim()+ 
                    "   "+ 
                    nameAndPriceSplit[1].Trim() + "\n";

                orderDetails=detailsOfOrder;

                unitPrice += float.Parse(nameAndPriceSplit[1].Trim().Remove(0, 1));

                priceOfOrder +=float.Parse(nameAndPriceSplit[1].Trim().Remove(0,1));

                this.quantity = quantity;
            }


        }
       
    }
}
    