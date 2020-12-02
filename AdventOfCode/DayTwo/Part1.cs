using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.DayTwo
{
    public class Part1
    {
        public int GetAnswer()
        {
            var allPasswords = PasswordReader.GetAllPasswords();
            var correctPasswords = 0;

            foreach (var pass in allPasswords)
            {
                var countOfLetter = pass.Password.ToArray().Count(a => a == char.Parse(pass.Letter));
                if(countOfLetter <= pass.MaxOccurrences &&
                    countOfLetter >= pass.MinOccurrences)
                {
                    correctPasswords++;
                }
            }

            return correctPasswords;
        }
    }
}
