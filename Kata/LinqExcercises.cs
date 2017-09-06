using System.Linq;

namespace Kata
{
    public class LinqExcercises
    {
        public static void Execute()
        {
            SplitStringsIntoGroups();
        }
        
        public static void SplitStringsIntoGroups()
        {
            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA",
                "ZURICH","NEW DELHI","AMSTERDAM",
                "ABU DHABI", "PARIS","NEW YORK"
            };

            var citySplit = from i in Enumerable.Range(0, cities.Length)
                group cities[i] by i / 3;

         
        }

    }
}