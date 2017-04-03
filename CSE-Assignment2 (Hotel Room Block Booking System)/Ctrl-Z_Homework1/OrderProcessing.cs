using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ctrl_Z_Homework1
{
    class OrderProcessing
    {
        double totalPrice = -1;
        public Order od = new Order();
        private double tax = .08;
        private double locationCharge = 100.00;
        public bool confirm = false;

        /*public void processStart()
        {
            for (Int32 i = 0; i < 2; i++)
            {
                Thread.Sleep(500);
                Thread processThread = new Thread(new ThreadStart(CalcAmount));
                od.setReceiverId(processThread.Name);
                Console.WriteLine("Starting thread {0}", processThread.Name);
                processThread.Start();
                Console.WriteLine("Order process complete");
            }
        }*/

        public void CalcAmount()
        {
            Hotel ho = new Hotel();
            //Encoder encode = new Encoder();
            //string line = encode.Encode(od);
            //Console.WriteLine(line);
            //Console.WriteLine("{0}, {1}, {2}", od.getCardNo(), od.getReceiverId(), od.getSenderId());
            bool check = checkCard(od.getCardNo());
            if (check == true)// && !ho.getRoomNum().Equals(0))
            {   
                Console.WriteLine("Card is valid");
                totalPrice = od.getUnitPrice() * od.getAmount() + tax + locationCharge;
                //order.setUnitPrice(roomPrice);
                Console.WriteLine("Total price is {0}", totalPrice);
                Console.WriteLine("rooms: {0}, order amount: {1}", ho.getRooms(), od.getAmount());
                Int32 takenRooms = ho.getRooms() - od.getAmount();
                Int32 roomCount = ho.getRooms() - od.getAmount();
                ho.updateRoomNumber(roomCount);
                od.setUnitPrice(totalPrice);
                Console.WriteLine("{0} rooms left", ho.getRooms());
                confirm = true;
            }
            else
            {
                Console.WriteLine("The card was declined");
                confirm = false;
            }
        }

        public bool checkCard(Int32 cardNo)
        {
            bool creditFlag;
            if (cardNo >= 1000 && cardNo <= 50000)
            {
                creditFlag = true;
            }
            else
            {
                creditFlag = false;
            }
            return creditFlag;
        }

    }
}
