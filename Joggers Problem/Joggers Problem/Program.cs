using Joggers_Problem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Joggers_Problem
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Enter Bob Lap Length:");
            int bobLapLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Charles Lap Length:");
            int charlesLapLength = Convert.ToInt32(Console.ReadLine());

            Lap obj = new Lap(bobLapLength,charlesLapLength);
            obj.numberOfLapsRequiredtoMeet();
        }
    }
}
