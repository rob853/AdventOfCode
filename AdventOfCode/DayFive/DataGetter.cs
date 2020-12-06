using System.Collections.Generic;
using System.IO;
using System;

namespace AdventOfCode.DayFive
{
    public static class DataGetter
    {
        public static List<PlaneModel> GetData()
        {
            var result = new List<PlaneModel>();
            using (var sr = new StreamReader("./DayFive/input.txt"))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    var plane = new PlaneModel
                    {
                        PlaneRow = line.Substring(0, 7),
                        PlaneColumn = line.Substring(7, 3)
                    };

                    result.Add(plane);                
                }
            }

            return result;
        }
    }
}