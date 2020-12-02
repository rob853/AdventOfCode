using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.DayTwo
{
    public class Part2
    {
        public int GetAnswer()
        {
            var allPasswords = PasswordReader.GetAllPasswords();
            var correctPasswords = 0;

            foreach (var pass in allPasswords)
            {
                var firstPosition = pass.Password.ToArray()[pass.MinOccurrences - 1] == char.Parse(pass.Letter);
                var secondPosition = pass.Password.ToArray()[pass.MaxOccurrences - 1] == char.Parse(pass.Letter);

                if(firstPosition ^ secondPosition)
                {
                    correctPasswords++;
                }
            }

            return correctPasswords;
        }
    }
}
