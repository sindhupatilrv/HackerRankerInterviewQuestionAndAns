public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Given a signed 32-bit integer x, return x with its digits reversed. " +
            "If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1],hen return 0.\r\n\r\n" +
            "Assume the environment does not allow you to store 64-bit integers (signed or unsigned).");

        //LeetCode Problem 7 Reverse Integer
        /*
        Example 1:

            Input: x = 123
            Output: 321
            Example 2:

            Input: x = -123
            Output: -321
            Example 3:

            Input: x = 120
            Output: 21 
        */
        Console.WriteLine("\n\nEnter an Integer Number to Reverse: Wheather its positive or negative or anythingt");
        var intnumber = Console.ReadLine();
        int number = int.Parse(intnumber);
        int reversenumber = reverseInt(number);
        Console.WriteLine("Reversed Number is: " + reversenumber);
    }

    public static int reverseInt(int x)
    {
        int sign = x < 0 ? -1 : 1;
        x = Math.Abs(x);
        int reversed = 0;
        int rem = 0;
        while (x > 0)
        {
            rem = x % 10;
            reversed = reversed * 10 + rem;
            x = x / 10;
        }
        return reversed * sign;
    }
}