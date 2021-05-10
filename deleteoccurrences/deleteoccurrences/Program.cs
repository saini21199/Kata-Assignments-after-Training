using System;

namespace deleteoccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many elements do you want to add in array");
            int arrSize = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[arrSize];

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < arrSize; i++) {
                arr[i] = Convert.ToInt32(Console.ReadLine());    
            }

            Console.WriteLine("Enter atmost Occurence");
            int occurence=Convert.ToInt32(Console.ReadLine());

            DeleteOccurrence operation = new DeleteOccurrence(occurence,arr);
            operation.DeleteNth();
        }
    }
}
