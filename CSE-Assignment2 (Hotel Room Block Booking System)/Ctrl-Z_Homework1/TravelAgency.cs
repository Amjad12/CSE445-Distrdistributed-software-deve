using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ctrl_Z_Homework1
{
    class TravelAgency
    {
        public string threadId;
        public void travelAgencyFunc()
        {
            threadId = Thread.CurrentThread.Name;
            //Hotel hotel = new Hotel();
            for (Int32 i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                double p = Hotel.getPrice();  //Hotel.getPrice();
                Console.WriteLine("agency{0} has everyday low price of ${1} each", threadId, p);
            }
        }

        public void hotelOnSale(Double p)
        { //Event handler 
          //order HotelRooms - send oreder into queue
          OrderRooms();
          Console.WriteLine("Store{0} Hotels are on sale: as low as ${1} each", threadId, p);
        }
            
        public void OrderRooms()
        {
            Console.WriteLine("IN ORDER ROOMS");
            Random r = new Random();
            int Max = 10;
            Order order = new Order();

            if (order.getAmount() <= Max)
            {
                order.setAmount(r.Next(2,10));
                Console.WriteLine("Agencey{0} is placing an order for {1} rooms", threadId, order.getAmount());

            }
            order.setSenderId(threadId);
            Int32 card = r.Next(100, 50000);
            order.setCardNo(card);

            Encoder en = new Encoder();
            var stringOrder = en.Encode(order);

            MainClass.mcb.setOneCell(stringOrder);
            Console.WriteLine("{0} sent to MCB cell", stringOrder);
        }

       /* public void orderComplete()
        {
            String[] completeOrders = new String[10];
            for (int i; i < completeOrders.Length; i++)
            {
                completeOrders[i] = 
            }
        }*/
    }

}

