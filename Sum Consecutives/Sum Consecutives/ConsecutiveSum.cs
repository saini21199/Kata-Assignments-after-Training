using System;
using System.Collections.Generic;
using System.Text;

namespace Sum_Consecutives
{
    public class ConsecutiveSum
    {
        public List<int> s { get; set; }
        public ConsecutiveSum(List<int> list) {
            this.s = list;
        }
        public void findSumConsecutives()
        {
            int count = 1;
            for (int i = 0; i < s.Count - 1; i++)
            {
                count = 1;
                if (s[i] == s[i + 1])
                {
                    int index = i;
                    int temp = s[i];
                    while (s[i] == s[i + 1])
                    {
                        s.RemoveAt(i + 1);
                        count++;
                    }
                    s.RemoveAt(index);
                    s.Insert(index, count * temp);
                }
            }
           
            Console.WriteLine("List after finding Sum of consecutive elements");
            s.ForEach(i => Console.WriteLine(i));
        }
    }
}
