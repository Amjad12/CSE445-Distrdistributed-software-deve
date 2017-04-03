using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ctrl_Z_Homework1
{
    public delegate void priceCutEvent(double price);
    //public delegate void confirmOrder(string stringOrder);

    class Hotel
    {
        //private Int32 p = 20; // price cut counter
        //public Int32 numOrders;
        private Int32 rooms = 500;
        private static double roomPrice = 500; 
        public static event priceCutEvent priceCutEvent;
        //public static event confirmOrder confirmOrder;
       
        public static double getPrice()
        {
            return roomPrice;
        }

        public Int32 getRooms()
        {
            return rooms;
        }

        public void updateRoomNumber(Int32 roomCount)
        {
            rooms = roomCount;
        }

        public void priceCut(double newPrice)
        {
            Int32 p = 20;
            //double newPrice = PricingModel(MainClass.mcb.numOrders);
            if (newPrice < roomPrice && p>0)
            {
                //price cut event
                p--; //decrease price cut counter
                roomPrice = newPrice;
                priceCutEvent(roomPrice);
                //price cut event
            }
        }

        public void HotelFunc()
        {
            for(Int32 i = 0; i<50 ; i++)
            {
                Thread.Sleep(500);
                Thread orderThread = new Thread(new ThreadStart(getOrder));
                orderThread.Start();
                Console.WriteLine("New Hotel Room Price is ${0}", roomPrice);
            }
        }

        public void getOrder()
        {
            var stringOrder = MainClass.mcb.getOneCell();
            Console.WriteLine("String Order is {0}", stringOrder);
            Decoder decode = new Decoder();
            OrderProcessing process = new OrderProcessing();
            process.od = decode.Decode(stringOrder);
            process.CalcAmount();
            if(process.confirm == true)
            {
                int i = 0;
            }
            PricingModel(MainClass.mcb.numOrders);
        } 
         
        double PricingModel(Int32 numOrders) //Calculates price of a room
        {
            Console.WriteLine("numOrders is {0}", numOrders);
            Random rnd = new Random();
            double roomPrice = rnd.Next(1, 500);
            Console.WriteLine("New  Price is {0}", roomPrice);
            priceCut(roomPrice);
            /*
            double newPrice = -1;
            if (numOrders > rooms/10)
            {
                newPrice = rnd.Next(276, 500);
            }
            else
            {
                newPrice = rnd.Next(1, 274);
            }
            Console.WriteLine("New Price Calculated at {0}", newPrice);
            */
            return roomPrice;
        }
    }
}
