namespace ConsoleAppStringpractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Username Validation 💡 Scenario: You are building a login system where usernames must be at least 5 characters long
            //  .Write a C# program that takes a username as input and checks if it meets the length requirement.

            Console.WriteLine("Enter a valid username:");
            String Username = Console.ReadLine();

            if (Username.Length >= 5)
            {
                Console.WriteLine("Invalid Username");
            }
            else
            {
                Console.WriteLine("Valid Username");
            }


            // Count Vowels in a Sentence

            Console.WriteLine("Enter a Sentence :");
            string Sentence = Console.ReadLine();

            string vowels = "AEIOUaeiou";
            int vowelCount = 0;

            foreach (char c in Sentence)
            {
                if (vowels.Contains(c))
                    vowelCount++;
            }

            Console.WriteLine($"number of vowels in a Sentence is {vowelCount}");

            // Check if a String is a Palindrome

            Console.WriteLine("Enter a String:");
            string input = Console.ReadLine();
            string reversed = new string(input.ToCharArray().Reverse().ToArray());

            if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("It is a Palindrome");
            }
            else
            {
                Console.WriteLine("It is not a Palindrome");
            }

            //Replace a word

            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            string censored = sentence.Replace("ayushi", "idiot");
            Console.WriteLine($" {censored}");

            //finding 1 and last character of a string

            Console.WriteLine("Enter a Sentence");
            string senc = Console.ReadLine();

            if (senc.Length > 0)
            {
                Console.WriteLine($"First Word : {senc[0]}");
                Console.WriteLine($"Last Word : {senc[senc.Length - 1]}");
            }
            else
            {
                Console.WriteLine("String is empty");
            }

            //concatenate two strings.


            Console.WriteLine("Enter one string");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter another string");
            string s2 = Console.ReadLine();


            Console.WriteLine("Do you want to concate both the string ?");
            string s3 = Console.ReadLine();

            if (s3 == "yes")
            {
                string Res = s1 + s2;
                Console.WriteLine($"Concatenated string : {Res}");
            }
            else
            {
                Console.WriteLine("Thankyou");
            }

            //checking if a sentence contains a particular word

            Console.WriteLine("Enter a Sentence");
            string sentence1 = Console.ReadLine();

            Console.WriteLine("Enter a Word:");
            string word = Console.ReadLine();


            if (sentence1.Contains(word))
            {
                Console.WriteLine($"The sentence has the word {word}");
            }
            else
            {
                Console.WriteLine($"The sentence does not contain {word}");
            }
                   
















            //enums
            //dynamic
            //var,implicit
            //nullable ?
            //null collaging , compare from nullable class
        }
    }
}
