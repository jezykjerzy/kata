

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kata
{
    /*
     *Liczy wystąpienia danej litery w stringu, caseinsensitive */
    class DuplicateCounter
    {
        public static void execute()
        {
            string str = "aabbbcde";
            str = Console.ReadLine();

            while (str != "q")
            {
                Console.WriteLine(DuplicateCount(str));
                str = Console.ReadLine();
            }
        }

        public static int DuplicateCount(string str)
        {
            int i;
            char letter;

            int duplicatesCount = i = 0;
            var wordLenght = str.Length;

            while (i < wordLenght)
            {

                letter = str.ElementAt(i);
                i++;
                if (letterOccurencesInString(letter, str) > 1)
                {
                    duplicatesCount++;
                    str = deleteDuplicates(letter, str);
                    wordLenght = str.Length;
                    i = 0;
                }

            }
            return duplicatesCount;
        }

        static int letterOccurencesInString(char ch, string str)
        {
            int n = str.Count(x => x == ch || x == char.ToUpper(ch) || x == char.ToLower(ch));
            return n;
        }

        static string deleteDuplicates(char letterToDelete, string str)
        {
            string pattern = "[" + char.ToUpper(letterToDelete).ToString() + char.ToLower(letterToDelete) + "]";
            str = Regex.Replace(str, pattern, "");
            return str;
        }
    }
}