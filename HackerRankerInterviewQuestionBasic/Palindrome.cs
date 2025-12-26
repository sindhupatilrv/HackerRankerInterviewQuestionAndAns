using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayProgram;

namespace HackerRankerInterviewQuestionBasic
{
    public class Palindrome
    {
        public Palindrome()
        {
            int x = 121;
            // logic - reverse the original number and check reverse number/string and match to orginial number
            //s string originalString = "Madam";
            //  string reversString = new string(originalString.Reverse().ToArray());
            //   Console.WriteLine(reversString);

            var originalString = "Madam";
            char[] chars = originalString.ToCharArray();
            Array.Reverse(chars);
            var reverseString = new string(chars);
            Console.WriteLine(reverseString);

            int originalnumber = 121, rem = 0;
            int reverseNo = 0;
            while (originalnumber > 0)
            {
                rem = originalnumber % 10;
                reverseNo = (reverseNo * 10) + rem;
                originalnumber = originalnumber / 10;
            }
            Console.WriteLine(reverseNo);
            if (originalnumber == reverseNo)
            {
          //      true;
            }
        }
    }
}
