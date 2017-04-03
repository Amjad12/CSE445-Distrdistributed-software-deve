using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ctrl_Z_Homework1
{
    class MainClass
    {
        public static MultiCellBuffer mcb = new MultiCellBuffer();
        static void Main(string[] args)
        {

            //Console.WriteLine("Testing console");
            //Testing test = new Testing();

            //test.testDecoder();
            //test.testOrderProcessing();
            //Order orders = new Order();
            //Encoder encode = new Encoder();
            //String line = encode.Encode(test.order);
            //Console.WriteLine(test.order.getAmount());

            //Console.ReadLine();

            Hotel hotel1 = new Hotel();
            Hotel hotel2 = new Hotel();
            Thread h1 = new Thread(new ThreadStart(hotel1.HotelFunc));
            Thread h2 = new Thread(new ThreadStart(hotel1.HotelFunc));
            h1.Start();
            h2.Start();
            TravelAgency agency = new TravelAgency();
            
            Hotel.priceCutEvent += new priceCutEvent(agency.hotelOnSale);
           // Hotel.confirmOrder += new confirmOrder(mcb.numOrders);
            Thread[] agencies = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                agencies[i] = new Thread(new ThreadStart(agency.travelAgencyFunc));
                agencies[i].Name = (i + 1).ToString();
                agencies[i].Start();
            }


           
            Console.ReadLine();


        }
    }
}
