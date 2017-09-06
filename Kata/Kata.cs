using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Machine.Specifications.Utility;

namespace Kata
{
    public class Kata
    {
        
        
        public static string ToJadenCase(string phrase)
        {
            // Jaden Casing Strings
            return string.Join(" ", phrase.Split(' ').Select(e => e.First().ToString().ToUpper() + e.Substring(1)));
        }

        public static string ToJadenCaseKataSolution(string phrase)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
        }

        public static string SpinWords(string sentence)
        {
            // Stop gninnipS My sdroW!

            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 5)
                    words[i] = string.Join("", words[i].ToCharArray().Reverse().ToArray());
            }

            return string.Join(" ", words);
        }

        public static string SpinWordsKataSolution(string sentence)
        {
            return string.Join(" ",
                sentence.Split(' ').Select(x => x.Length >= 5 ? new string(x.Reverse().ToArray()) : x));
        }

        // Build Tower
        public static string[] TowerBuilder(int nFloors)
        {
           
            string[] towerArray = new string[nFloors + 2];

            string leftOrnaments = "  '";
            string rightOrnaments = "', ";
            string floorEmptySpace = "";
            string floor = "";

            int i = 0;
            List<string> towerList = new List<string>();

            towerList.Add("[\n");
            for (int x = nFloors - 1; x >= 0; x--, i++)
            {
              
                floor += new string(' ', x);
                floor += new string('*', nFloors - x);
                floor += new string('*', i);
                floor += new string(' ', x);
                floor += "\n";

                towerList.Add(floor);
            }

            towerList.Add("]");
            towerArray = towerList.ToArray();
            
            return towerArray;
        }



    }
}