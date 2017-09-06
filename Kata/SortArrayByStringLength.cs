using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class SortArrayByStringLength 
    {

        public void Execute()
        {

        }

        public static string[] SortByLength(string[] array)
        {
            return array.OrderBy(x => x.Length).ToArray();
        }

       

    }
}