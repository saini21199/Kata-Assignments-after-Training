using System;
using System.Collections.Generic;
using System.Text;

namespace productlcmdiffernce
{
    public class SumDifferencesBetweenProductsAndLCM
    {
        public int[,] arr { get; set; }

        public SumDifferencesBetweenProductsAndLCM(int[,] array) {
            this.arr = array;
        }
        private int findLCM(int x, int y)
        {
            int max = (x < y) ? y : x;
            if (x == 0)
                return 0;
            else if (y == 0)
                return 0;
            else
            {
                while (true)
                {
                    if (max % x == 0 && max % y == 0)
                    {
                        return max;
                    }
                    max++;
                }
            }
        }

        public void calculateResult() {
            int sum = 0;
            int product, LCM;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                product = this.arr[i,0] * this.arr[i,1];
                LCM = findLCM(this.arr[i,0], this.arr[i,1]);
                sum = sum + (product - LCM);
            }

            Console.WriteLine("Sum of Differences between product and LCM of given 2-D array = " + sum);
        }
    }
}
