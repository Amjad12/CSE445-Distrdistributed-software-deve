using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ctrl_Z_Homework1
{
    class MultiCellBuffer
    {
        public Semaphore semaphore = new Semaphore(3, 3);
        private string[] mcb = new string[3]; 
        public Int32 numOrders;

        public MultiCellBuffer()
        {
            for (int i = 0; i < mcb.Length; i++)
            {
                mcb[i] = String.Empty;
            }
        }
        public string getOneCell()
        {
            string value = "Empty";
            for (int i = 0; i<mcb.Length; i++)
            {
                
                if(mcb[i] != String.Empty)
                {
                    value = mcb[i];
                    mcb[i] = String.Empty;
                    for (int j = 0; j < mcb.Length; j++)
                    {
                        Console.WriteLine("Getting cell {0} contains {1}", i, mcb[i]);
                    }
                    semaphore.Release(1);
                }
            }
            return value;
        }
        
        public void setOneCell(string order)
        {
            semaphore.WaitOne();
            for (int i = 0; i < mcb.Length; i++)
            {
                if (mcb[i] == String.Empty)
                {
                    lock (mcb[i])
                    {
                        mcb[i] = order;
                        numOrders++;
                    }
                    for(int j = 0; j < mcb.Length; j++)
                    {
                        Console.WriteLine("Setting cell {0} contains {1}", i, mcb[i]);
                    }
                    break;
                }
            }
        }

    }
}
