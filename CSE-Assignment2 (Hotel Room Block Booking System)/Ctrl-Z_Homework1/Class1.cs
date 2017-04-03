using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading;

namespace event_driven_example

{

    public delegate void priceCutEvent(Int32 pr); // define a delgate

    public class ChickenFarm

    {

        public static Random rng = new Random(); //To genrate random numbers

        public static event priceCutEvent priceCut; // link event to delegate

        private static Int32 chickenPrice = 10;

        public Int32 getPrice()

        {

            return chickenPrice;

        }

        public static void changePrice(Int32 price)

        {

            if (price < chickenPrice)
            {
                if (priceCut != null)

                    priceCut(price);
            }
            chickenPrice = price;
        }
        public void farmFunc()
        {
            for (Int32 i = 0; i < 50; i++)
            {
                Thread.Sleep(500);
                //take the order from the qoute of the orders
                //decide the price based on the orders
                Int32 p = rng.Next(5, 10);
                //Console.WriteLine(&quot;New Price is {0}&quot;, p);
                ChickenFarm.changePrice(p);
            }
        }
    }
        public class Retailer
        {
            public void retailerFunc()
            {
                ChickenFarm chicken = new ChickenFarm();
                for (Int32 i = 0; i < 10; i++)
                {
                    Thread.Sleep(1000);
                    Int32 p = chicken.getPrice();
                    Console.WriteLine("Store{0} everyday price: ${1} each", Thread.CurrentThread.Name, p);
                }
            }
            public void chickenOnSale(Int32 p)
            { //Event handler 
              //order chicken from chicken
                Console.WriteLine("Store{0} chickens are on sale: as low as ${1} each", Thread.CurrentThread.Name, p);
            }
        }

    /*
        public class myApplication
        {
            static void Main(string[] args)
            {
                ChickenFarm chicken = new ChickenFarm();
                Thread farmer = new Thread(new ThreadStart(chicken.farmFunc));
                farmer.Start();
                Retailer chickenstore = new Retailer();
                ChickenFarm.priceCut += new priceCutEvent(chickenstore.chickenOnSale);
                Thread[] retailers = new Thread[3];
                for (int i = 0; i < 3; i++)
                {
                    retailers[i] = new Thread(new ThreadStart(chickenstore.retailerFunc));
                    retailers[i].Name = (i + 1).ToString();
                    retailers[i].Start();
                }
            Console.ReadLine();

            }

        }

    */
    }

