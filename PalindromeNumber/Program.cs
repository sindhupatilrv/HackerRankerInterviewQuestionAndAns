public class Program
{
    /*
     * 9. Palindrome Number
     * Example 1:

        Input: x = 121
        Output: true
        Explanation: 121 reads as 121 from left to right and from right to left.
        Example 2:

        Input: x = -121
        Output: false
        Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
        Example 3:

        Input: x = 10
        Output: false
        Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
     */
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter a number wants to Check if its Palindrome or not");
        var number = Console.ReadLine();
        int convertToInt = int.Parse(number);
        bool flag = IsPalindrome(convertToInt);
        Console.WriteLine("Entered number '{0}' is Palindrome and Boollen response is '{1}'", convertToInt, flag);
}

    private static bool IsPalindrome(int number)
    {
        int originalNumer = number;
        int reverseNumber = 0;
        int remainder = 0;
        while(number < 0) return false;
        while(number > 0)
        {
            remainder = number % 10;
            reverseNumber = reverseNumber * 10 + remainder;
            number = number / 10;
        }
        return originalNumer == reverseNumber;
    }
}