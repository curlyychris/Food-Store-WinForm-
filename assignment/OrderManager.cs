using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    public class OrderManager
    {
        public List<OrderDetails> orders = new List<OrderDetails>();


        public bool DoesTheOrderExist(OrderDetails orderDetails,int quanityOfOrder)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].DetailsOfOrder() == orderDetails.DetailsOfOrder())
                {
                    IncreaseQuantityOfExistingOrder(i, quanityOfOrder);

                    return true;
                }
            }

            return false;
        }

        public void IncreaseQuantityOfExistingOrder(int orderIndex,int quantity)
        {
            orders[orderIndex].ChangesQuantity(orders[orderIndex].Quantity() + quantity);
        }
    }
}
