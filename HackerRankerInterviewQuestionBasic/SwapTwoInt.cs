using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankerInterviewQuestionBasic
{
   public class SwapTwoInt
    {
        public SwapTwoInt() {
            int number1 =10, number2 = 20, number3;
            Console.WriteLine("Before Swaping Number are" + number1, number2);
            number3 = number1;
            number1 = number2;
            number2 = number3;
            Console.WriteLine("After Swaping Number are" + number1, number2);

        }

    }

}
