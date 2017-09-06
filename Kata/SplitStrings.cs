using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Kata
{
    public class SplitStrings
    {
        public static void execute()
        {
            string str = "";
            string[] array;

            str = Console.ReadLine();
            
            while (str != "q")
            {
                array = Solution(str);
                foreach (var i in array)
                    Console.Write(i + " ");

                Console.WriteLine();
                str = Console.ReadLine();
            }
        }

        // moje 
        public static string[] Solution(string str)
        {
            if (str.Length % 2 != 0)
                str += "_";
            
            string[] array = new string[str.Length/2];

            for (int i = 0; i < str.Length/2; i++)
                array[i] = str.Substring(i * 2, 2);
            
            return array;

        }

        //z codewars
        public static string[] SolutionCodeWars(string str)
        {
            if (str.Length % 2 != 0)
                str += "_";

            return Enumerable.Range(0, str.Length)
                .Where(x => x % 2 == 0)
                .Select(x => str.Substring(x, 2))
                .ToArray();
        }
    }
}