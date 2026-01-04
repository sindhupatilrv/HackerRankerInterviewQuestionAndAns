using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankerInterviewQuestionBasic
{
    public class IntToRoman
    {
        public IntToRoman()
        {
            Console.WriteLine("Enter the Number to Convert into Roman Numeral:");
            string enterNumber = Console.ReadLine();
            int number = Convert.ToInt32(enterNumber);

            Dictionary<int, string> romanNumerals = new Dictionary<int, string>();
            romanNumerals.Add(1, "I");
            romanNumerals.Add(2, "II");
            romanNumerals.Add(3, "III");
            romanNumerals.Add(4, "IV");
            romanNumerals.Add(5, "V");
            romanNumerals.Add(900, "CM");
            romanNumerals.Add(500, "D");
            romanNumerals.Add(400, "CD");
            romanNumerals.Add(100, "C");
            romanNumerals.Add(1000, "M");
      
            foreach (var num in romanNumerals)
            {
                if(num.Key.Equals(number))
                {
                    Console.WriteLine("Given Numer '{0}' and its Roman Numeral is '{1}'", number,  num.Value);
                    break;
                }
            }
        }
    }
}
