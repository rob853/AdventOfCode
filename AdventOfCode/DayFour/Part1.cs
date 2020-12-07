using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.DayFour
{
    public class Part1
    {
        public int GetAnswer()
        {
            var passports = DataGetter.GetData();
            var answer = PassportValidator.GetValidPassportCount(passports);
            
            return answer;
        }
    }
}
