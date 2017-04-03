using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctrl_Z_Homework1
{
    class Decoder
    {
        private Order order = new Order();

        public Order Decode(string stringOrder)
        {
            if (!stringOrder.Equals("Empty"))
            {
                Console.WriteLine("Decoding order {0}", stringOrder);
                char delimiter = ',';
                string[] orderArray = stringOrder.Split(delimiter);
                order.setSenderId(orderArray[0]);
                order.setCardNo(Convert.ToInt32(orderArray[1]));
                order.setReceiverId(orderArray[2]);
                order.setAmount(Convert.ToInt32(orderArray[3]));
                order.setUnitPrice(Convert.ToDouble(orderArray[4]));
            }
            else
            {
                Console.WriteLine("Order Object is null");
            }
            return order;
        }
    }
}
