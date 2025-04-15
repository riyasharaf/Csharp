namespace ConsoleApppractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void getarray(params int[] a)
            {

                {
                    foreach (int i in a)


                        Console.WriteLine(i);
                }
            }


            static void Main(string[] args)
            {
                //1-D ARRAYS DECLARATION

                int[] myNumbers = new int[5] { 1, 2, 3, 4, 5 };

                //accessing 1 - d arrays
                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine("Element at index {0} is: {1}", i, myNumbers[i]);
                }


                //accessing elements of 1 - d arrays using foreach loop


                foreach (int num in myNumbers)
                {
                    Console.WriteLine(num);
                }



                //2D ARRAYS DECLARATION
                int[,] my2DNumbers = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

                //accessing elements of 2-d arrays

                Console.WriteLine(my2DNumbers[0, 1]);


                //tic-tac-toe using 2-D Arrays
                string[,] tictactoe = new string[3, 3] { { "x", "x", "o" }, { "o", "x", "x" }, { "x", "o", "x" } };


                //accessing a particular element 
                Console.WriteLine(tictactoe[0, 2]);


                //jagged array 
                int[][] jaggedArray = new int[3][];

                jaggedArray[0] = new int[] { 1, 2, 3 };
                jaggedArray[1] = new int[] { 4, 5 };
                jaggedArray[2] = new int[] { 6, 7, 8, 9 };


                //printing a jagged array

                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    Console.Write("Row " + i + ": ");
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        Console.Write(jaggedArray[i][j] + " ");
                    }
                    Console.WriteLine();
                }

            }
        }
}
