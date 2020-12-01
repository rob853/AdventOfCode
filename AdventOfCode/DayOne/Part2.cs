using System;
using System.Collections.Generic;

namespace AdventOfCode.DayOne
{
    public class Part2
    {
        public int GetAnswer(List<int> nums)
        {
            foreach (var num1 in nums)
            {
                foreach (var num2 in nums)
                {
                    foreach (var num3 in nums)
                    {
                        if (num1 + num2 + num3 == 2020)
                        {
                            return num1 * num2 * num3;
                        }
                    }
                }
            }

            throw new ArithmeticException("No answer found");
        }
    }
}
