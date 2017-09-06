using System;
using System.Linq;

namespace Kata
{
    // Printer Errors

    public class PrinterErrors
    {
        public static void execute()
        {
            string str = "";
            str = Console.ReadLine();

            while (str != "q")
            {
                Console.WriteLine(PrinterError(str));
                str = Console.ReadLine();
            }
        }

        // moje rozwiązanie
        public static string PrinterError(String s)
        {
            return s.Count(c => c > 'm').ToString() + "/" + s.Length.ToString();
        }
    }
}