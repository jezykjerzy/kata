using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class ListFilterer 
    {
        public static void Execute()
        {
        }
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems.OfType<int>().Cast<int>();
        }
    }
}