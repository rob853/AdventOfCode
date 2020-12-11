using System.Collections.Generic;
using System.IO;

namespace AdventOfCode.DayNine
{
    public static class DataGetter
    {
        public static List<long> GetData()
        {
            var result = new List<long>();
            using (var sr = new StreamReader("./DayNine/input.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    result.Add(long.Parse(line));
                }
            }

            return result;
        }
    }
}