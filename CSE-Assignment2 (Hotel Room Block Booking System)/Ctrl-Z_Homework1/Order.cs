using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctrl_Z_Homework1
{
    public class Order
    {
        private string senderId;
        private Int32 cardNo;
        private string receiverId;
        private Int32 amount;
        private double unitPrice;

        public Order()
        {
            senderId = "";
            cardNo = 0;
            receiverId = "";
            amount = 0;
            unitPrice = 0.0;
        }

        public string getSenderId()
        {
            return senderId;
        }

        public Int32 getCardNo()
        {
            return cardNo;
        }

        public void setCardNo(Int32 card)
        {
            cardNo = card;
        }

        public string getReceiverId()
        {
            return receiverId;
        }

        public void setReceiverId(string newReceiverId)
        {
            receiverId = newReceiverId;
        }
        public void setSenderId(string newId)
        {
            senderId = newId;
        }

        public int getAmount()
        {
            return amount;
        }
        

        public void setAmount(int newAmount)
        {
            amount = newAmount;
        }

        public double getUnitPrice()
        {
            return unitPrice;
        }

        public void setUnitPrice(double price)
        {
            unitPrice = price;
        }
    }
}
