using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deleteoccurrences
{
    public class DeleteOccurrence
    {
        public int atmostOccurrence { get; set; }
        public int[] arr { get; set; }

        public DeleteOccurrence(int N,int [] array) {
            this.arr = array;
            this.atmostOccurrence = N;
        }
        public void DeleteNth()
        {
            List<int> a = new List<int>();
            a = arr.ToList();
            int count = 0;
            for (int i = 0; i < a.Count; i++)
            {
                count = 0;
                for (int j = 0; j < a.Count; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                    }
                    if (count > this.atmostOccurrence && a[i] == a[j])
                    {
                        a.RemoveAt(j);
                        j--;
                    }
                }
            }

            int[] ar = a.ToArray();
            Console.Clear();
            Console.WriteLine("Array after removing elements");

            for (int i = 0; i < ar.Length; i++) {
                Console.WriteLine(ar[i]);
            }
        }
    }
}
