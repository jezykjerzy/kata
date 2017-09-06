using System.Linq;

namespace Kata
{
    public class FirstNonRepeatingLetter
    {
        public static string FirstNonRepeatingLetterInSentence(string s)
        {   
            char firstNonRepeatingLetter = s.FirstOrDefault(x => s.Count(c => c == char.ToUpper(x) || c == char.ToLower(x)) == 1);

            if (firstNonRepeatingLetter == 0)
                return "";
            else
                return "" + firstNonRepeatingLetter;
        }

        public static string FirstNonRepeatingLetterSolution(string s)
        {
            var ret = s.GroupBy(z => char.ToLower(z)).Where(g => g.Count() == 1).FirstOrDefault();
            return (ret != null) ? ret.First().ToString() : string.Empty;
        }
    }
}