using System;
using System.Collections.Generic;
using System.Text;

namespace Joggers_Problem.Entity
{
    public class Lap
    {
        public int bobLapLength { get; set; }
        public int charlesLapLength { get; set; }
        public Lap(int x, int y)
        {
            this.bobLapLength = x;
            this.charlesLapLength = y;
        }
        public void numberOfLapsRequiredtoMeet()
        {
            int maxLapLength = (this.bobLapLength > this.charlesLapLength) ? this.bobLapLength : this.charlesLapLength;
            int bobRequiredLap, charlesReuiredLap;
            while (true)
            {
                if (maxLapLength % this.bobLapLength == 0 && maxLapLength % this.charlesLapLength == 0)
                {
                    bobRequiredLap = maxLapLength / bobLapLength;
                    charlesReuiredLap = maxLapLength / charlesLapLength;
                    break;
                }
                maxLapLength++;
            };

            Console.WriteLine("Bob requires " + bobRequiredLap + " Laps to meet  Charles again");
            Console.WriteLine("Charles requires " + charlesReuiredLap + " Laps to meet again Bob again");
        }

    }
}
