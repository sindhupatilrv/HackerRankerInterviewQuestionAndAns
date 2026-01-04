using System.Net.NetworkInformation;

namespace ArrayProgram
{
    public class ReverseString
    {
        public ReverseString() {
            Console.WriteLine("Reverse the string value using Array.Reverse");

            var originalString = "Hello123$%#";
            //Using Array.Reverse
            char[] chars = originalString.ToCharArray();
            Array.Reverse(chars);
            var array_reverse_Concept = new string(chars);
            Console.WriteLine("Using ArrayConcept: -" + array_reverse_Concept);

            //Usr LINQ
            var reverse_Linq = new string(originalString.Reverse().ToArray());
            Console.WriteLine("Using Linq Concept:-" + reverse_Linq);

            Console.WriteLine("Reverse Complete Sentence Without space");
            var originalSentence = "Welcome to the world of CSharp";
            char[] charArray = originalSentence.ToCharArray();
            Array.Reverse(charArray);
            var reversedSentence = new string(charArray);
            Console.WriteLine("Reversed Sentence:-" + reversedSentence);


        }

    }
}