using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    /*
     * 13. Roman to Integer -  LeetCode Problem
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
            RomanValuesAssignment.Add("I",1);
            RomanValuesAssignment.Add("V", 5);
            RomanValuesAssignment.Add("X", 10);
            RomanValuesAssignment.Add("L", 50);
            RomanValuesAssignment.Add("C", 100);
            RomanValuesAssignment.Add("D", 500);
            RomanValuesAssignment.Add("M", 1000);
            //RomanValuesAssignment["M"] = 1000;
            //RomanValuesAssignment["I"] = 1;
            //RomanValuesAssignment["V"] = 5;
            //RomanValuesAssignment["X"] = 10;
            //RomanValuesAssignment["L"] = 50;
            //RomanValuesAssignment["C"] = 100;
            //RomanValuesAssignment["D"] = 500;
            //RomanValuesAssignment["M"] = 1000;
            Console.WriteLine("Enter Roman Values:");
            string romanInput = Console.ReadLine();

            //for one conversion this logic will work
           foreach(var romanchar in RomanValuesAssignment)
            {
                if (romanInput == romanchar.Key)
                {
                    Console.WriteLine("Integer Value is:\t " + romanchar.Value);
                    //return;
                }
            }

            // if more than one character is present in the input
           
            int total = 0;
            for(int i = 0; i < romanInput.Length; i++)
            {
                foreach(var romanchar in RomanValuesAssignment)
                {
                    if(romanInput[i].ToString() == romanchar.Key)
                    {
                        if (i + 1 < romanInput.Length &&
                        RomanValuesAssignment[romanInput[i].ToString()] <
                        RomanValuesAssignment[romanInput[i + 1].ToString()])
                        {
                            total = total - romanchar.Value;
                        }
                        else
                        {
                            total = total + romanchar.Value;
                        }
                        break;
                    }
                }
            }
            Console.WriteLine("Total Value of Given Roman Value is\t" + total);
        }
    }
}
