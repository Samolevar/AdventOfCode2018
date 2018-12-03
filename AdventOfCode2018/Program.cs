using System;

namespace AdventOfCode2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new DayFirst().ParseInput("./Inputs/Input_1-1.txt").Item1);
            Console.WriteLine(new DayFirst().ParseInputSecond("./Inputs/Input_1-2.txt"));
        }
    }
}
