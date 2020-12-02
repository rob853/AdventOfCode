using System.Collections.Generic;
using System.IO;

namespace AdventOfCode.DayTwo
{
    public static class PasswordReader
    {
        public static List<PasswordModel> GetAllPasswords()
        {
            var result = new List<PasswordModel>();
            using (var sr = new StreamReader("../../../DayTwo/inputs.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var splitBySpace = line.Split(" ");
                    var splitByDash = splitBySpace[0].Split("-");
                    var min = int.Parse(splitByDash[0]);
                    var max = int.Parse(splitByDash[1]);
                    var letter = line.Substring(line.IndexOf(":") - 1, 1);
                    var password = line.Substring(line.IndexOf(":") + 2);

                    result.Add(new PasswordModel
                    {
                        Letter = letter,
                        MaxOccurrences = max,
                        MinOccurrences = min,
                        Password = password

                    });
                }
            }

            return result;
        }
    }
}