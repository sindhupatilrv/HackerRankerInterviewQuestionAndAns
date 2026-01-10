public class Program{

    /*
     * Example 1:
     * Input: strs = ["flower","flow","flight"]
     * Output: "fl"
     * 
     * Example 2:
     * Input: strs = ["dog","racecar","car"]
     * Output: ""
     * Explanation: There is no common prefix among the input strings.
     */
    public static void Main(string[] args)
    {
        Console.WriteLine(" 14 Longest Common Prefix\n");
        string[] strs = new string[] { "flower", "flow", "flight" };

        var lenght = strs.Length;
        for (int i = 0; i < lenght; i++)
        {
            if (strs == null || strs.Length == 0)
            {
                Console.WriteLine("No Common Prefix");
            }

        }
    }
}