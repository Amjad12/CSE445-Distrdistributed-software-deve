using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctrl_Z_Homework1
{
    class Encoder
    {
        private string line;
        public string Encode(Order order)
        {
            if (!String.IsNullOrEmpty(order.getSenderId()))
            {
                line += order.getSenderId();
                line += ",";
            }
            else
            {
                line += "Empty";
                line += ",";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(order.getCardNo())))
            {
                line += Convert.ToString(order.getCardNo());
                line += ",";
            }
            else
            {
                line += "0000000000000000";
                line += ",";
            }

            if (!String.IsNullOrEmpty(order.getReceiverId()))
            {
                line += order.getReceiverId();
                line += ",";
            }
            else
            {
                line += "NoReciverIDProvided";
                line += ",";
            }
            if (order.getAmount() >= 0)
            {

                line += order.getAmount();
                line += ",";
            }
            else
            {
                line += "invalidAmount";
                line += ",";
            }
            if (order.getUnitPrice() >= 0)
            {
                line += Convert.ToString(order.getUnitPrice());
            }
            else
            {
                line += "None";
            }

            return line;
        }
    }
}
     
