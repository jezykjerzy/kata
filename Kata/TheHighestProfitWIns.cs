using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    class TheHighestProfitWIns
    {
        public static int[] minMax(int[] lst)
        {
            return new int[] {lst.Min(), lst.Max()};
        }

        public static void  execute()
        {
            string cmd = "";
           
            while (cmd != "q")
            {
                cmd = Console.ReadLine();
                int[] ints = minMax(cmd.Split(' ').Select(n => Convert.ToInt32(n)).ToArray());

                foreach (int i in ints)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
}
}
