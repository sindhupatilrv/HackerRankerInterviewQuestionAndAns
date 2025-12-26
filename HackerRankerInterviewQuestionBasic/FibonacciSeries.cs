using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankerInterviewQuestionBasic
{
    public class FibonacciSeries
    {
        public FibonacciSeries()
            //0,1,1,2,3,5,8,1
            {

            int firstNumber = 0;
            int secondNumber = 1;
            int nextNumber, count = 15;
            Console.WriteLine("Fibonacci Series upto to" + count);
            for (int i = 2; i < count; i++)
            {
                Console.WriteLine(firstNumber + "");
                nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
        }
    }

}
