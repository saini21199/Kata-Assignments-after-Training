using System;
using System.Collections.Generic;

namespace Sum_Consecutives
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many elements do you want to add in list");
            int listSize = Convert.ToInt32(Console.ReadLine());

            List<int> lst = new List<int>();

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < listSize; i++)
            {
                int x=Convert.ToInt32(Console.ReadLine());
                lst.Add(x);
            }
            Console.Clear();
            ConsecutiveSum operation = new ConsecutiveSum(lst);
            operation.findSumConsecutives();
        }
    }
}
