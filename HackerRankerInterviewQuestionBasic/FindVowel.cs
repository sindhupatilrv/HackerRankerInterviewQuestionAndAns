using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankerInterviewQuestionBasic
{
    public class FindVowel
    {
        public FindVowel()
        {
            string nameStr = "Welcome sindhu";
            char[] charArr = nameStr.ToCharArray();
            List<Char> vowels = new List<Char> { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;
            foreach (char c in charArr)
            {

                if (vowels.Contains(c))
                {
                    Console.WriteLine("Given String has Vowel in it");
                    count++;

                }

            }
            Console.WriteLine("Total Number of Vowel is " + count);
        }
    }
           
}
