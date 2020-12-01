using AdventOfCode.DayOne;
using System;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataGetter = new DataGetter();

            var nums = dataGetter.GetData();

            var answer = new Part2().GetAnswer(nums);

            Console.WriteLine(answer);
        }
    }
}
