using System;

namespace productlcmdiffernce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many pairs do you want to add in array");
            int row = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[row, 2];
            Console.WriteLine("Enter Your Pairs :");

            for (int i = 0; i < row; i++) {
                for (int j = 0; j < 2; j++) {
                    arr[i,j]= Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("Entered Pair:");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr[i,j]);
                }
                Console.Write("\n");
            }

            SumDifferencesBetweenProductsAndLCM operation = new SumDifferencesBetweenProductsAndLCM(arr);
            operation.calculateResult();
        }
    }
}
