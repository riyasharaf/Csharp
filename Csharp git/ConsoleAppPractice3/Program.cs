using System.Text;

namespace ConsoleAppPractice3
{
    internal class Program

    {


        static void valexam(int num)
        {
            num = 20;
        }

        static void refexam( ref int num)
        {
            num = 20;
        }

        static void Outexam(out int num1, out int num2)
        {
            num1 = 10; // Must be assigned
            num2 = 20;
        }
        static void getarray(params int[] a)
        {

            {
                foreach (int i in a)


                    Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {

            //params
            getarray(1, 2, 3, 4, 5);
            getarray(1, 2, 3);

            //Strings in c# declaration methods
            String s1 = "Riya";
            string s2 = "Rinal";
            string s3 = new string("Ayushi");
            char[] s4 = { 'a', 'b', 'c' };
            string s5 = new string(s4);
            Console.WriteLine(s5);

            string s7 = @"hi my anme is riyaaaa\\n 
                        riya kjedwhewkehreiureireie
                          ruhwiurh3ihrir3w
                            eerfeee";
            Console.WriteLine(s7);

            string s8 = "Riya";
            string s9 = "Ayushi";

            String s10 = $"{s8} and {s9} are friends";
            Console.WriteLine(s10);


            //if you want to create mutable string in c# using string builder method

            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(" World"); //append
            Console.WriteLine(sb);

            sb.Insert(5, " Beautiful"); //insert
            Console.WriteLine(sb);

            sb.Replace("Beautiful", "Amazing"); //replace
            Console.WriteLine(sb);

            sb.Remove(5, 8); // Removes 8 characters starting from index 5
            Console.WriteLine(sb);

            sb.Clear();
            Console.WriteLine(sb); // Output: (empty string)

            int x = 10;
            valexam(x);
            Console.WriteLine(x);

            int y = 10;
            refexam( ref y);
            Console.WriteLine(y);

            int a, b; // No need to initialize
            Outexam(out a, out b);
            Console.WriteLine($"a: {a}, b: {b}");










           
        }
    }
}
