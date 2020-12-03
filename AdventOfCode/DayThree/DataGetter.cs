using System;
using System.IO;
using System.Linq;

namespace AdventOfCode.DayThree
{
    public static class DataGetter
    {
        public static SlopeModel GetData()
        {
            var result = new SlopeModel();

            using (var sr = new StreamReader("../../../DayThree/input.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var row = new SlopeRow();
                    row.Location = line.Select(a => a.ToString()).ToList();
                    result.Rows.Add(row);
                }
            }

            return result;
        }
    }
}