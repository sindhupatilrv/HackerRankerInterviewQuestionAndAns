using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    /*
     * 13 -Romaon to Int value - LeetCode Problem
     * Example 1:

        Input: s = "III"
        Output: 3
        Explanation: III = 3.
        Example 2:

        Input: s = "LVIII"
        Output: 58
        Explanation: L = 50, V= 5, III = 3.
        Example 3:

        Input: s = "MCMXCIV"
        Output: 1994
        Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
     * */
    public class RomantoInteger
    {
        public void Romanto_Integer()
        {
            Dictionary<string, int> RomanValuesAssignment = new Dictionary<string, int>();
            RomanValuesAssignment["I"] = 1;
            RomanValuesAssignment["IV"] = 4;
            RomanValuesAssignment["V"] = 5;
            RomanValuesAssignment["X"] = 10;
            RomanValuesAssignment["L"] = 50;
            RomanValuesAssignment["XC"] = 90;
            RomanValuesAssignment["C"] = 100;
            RomanValuesAssignment["D"] = 500;
            RomanValuesAssignment["CM"] = 900;
            RomanValuesAssignment["M"] = 1000;

         //   RomanValuesAssignment["N"] = 0; // For handling the last character case

            Console.WriteLine("Enter Roman Values:");
            string romanInput = Console.ReadLine();

            //for one conversion this logic will work
           foreach(var romanchar in RomanValuesAssignment)
            {
                if (romanInput == romanchar.Key)
                {
                    Console.WriteLine("Integer Value is:" + romanchar.Value);
                    //return;
                }
            }

            // if more than one character is present in the input
           
            int total = 0;
            for(int i = 0; i < romanInput.Length; i++)
            {
                var temp = romanInput[i];
                foreach(var romanchar in RomanValuesAssignment)
                {
                    if(temp.ToString() == romanchar.Key)
                    {
                     //   Console.WriteLine("Integer Value is:" + romanchar.Value);
                        total = total + romanchar.Value;
                        break;
                    }

                }
            }
            Console.WriteLine("Total Value of Given Roman Value is" + total);
        }
    }
}
