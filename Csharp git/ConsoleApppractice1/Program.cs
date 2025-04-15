namespace ConsoleApppractice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, result;
            float floatresult;

            x = 7;
            y = 5;

            result = x + y;
            Console.WriteLine("x+y: {0}", result);

            result = x - y;
            Console.WriteLine("x-y: {0}", result);

            result = x * y;
            Console.WriteLine("x*y: {0}", result);

            result = x / y;
            Console.WriteLine("x/y: {0}", result);

            floatresult = (float)x / (float)y;
            Console.WriteLine("x/y: {0}", floatresult);

            result = x % y;
            Console.WriteLine("x%y: {0}", result);

            result += x;
            Console.WriteLine("result+=x: {0}", result);


            // Implicit conversion from int to double
            int num = 100;
            double dbll = num;
            Console.WriteLine(dbll);


            // Explicit conversion 
            double dblNum = 123.45;
            int intNum = (int)dblNum;
            Console.WriteLine(intNum);

            //usingToint to convert
            string strNum = "200";
            int num1 = Convert.ToInt32(strNum);
            Console.WriteLine(num1);

            //usingToString
            int num2 = 500;
            string str = num2.ToString();
            Console.WriteLine(str);

            //int to everydatatype
            int num3 = 100;
            double d = num3;
            float f = num3;
            long l = num3;
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(l);
            string str1 = num3.ToString();
            Console.WriteLine(str1);
            bool isPositive = num3 > 0;
            Console.WriteLine(isPositive);

            //double to everydatatype

            double d1 = 99.49;
            int i = (int)d1;
            long l1 = (long)d1;
            float f1 = (float)d1;
            Console.WriteLine(i);
            Console.WriteLine(l1);
            Console.WriteLine(f1);
            bool a = true;
            string str3 = a.ToString();
            Console.WriteLine(str3);

            //operators in csharp
            int a1 = 0;
            int preIncrement;
            int preDecrement;
            int postIncrement;
            int postDecrement;
            int positive;
            int negative;
            sbyte bitNot;
            bool logNot;

            preIncrement = ++a1;
            Console.WriteLine("pre-Increment: {0}", preIncrement);

            preDecrement = --a1;
            Console.WriteLine("pre-Decrement: {0}", preDecrement);

            postDecrement = a1--;
            Console.WriteLine("Post-Decrement: {0}", postDecrement);

            postIncrement = a1++;
            Console.WriteLine("Post-Increment: {0}", postIncrement);

            Console.WriteLine("Final Value of Unary: {0}", a1);

            positive = -postIncrement;
            Console.WriteLine("Positive: {0}", positive);

            negative = +postIncrement;
            Console.WriteLine("Negative: {0}", negative);

            bitNot = 0;
            bitNot = (sbyte)(~bitNot);
            Console.WriteLine("Bitwise Not: {0}", bitNot);

            logNot = false;
            logNot = !logNot;
            Console.WriteLine("Logical Not: {0}", logNot);
        }
    }
}
