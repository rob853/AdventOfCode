using System.Collections.Generic;
using System.IO;

namespace AdventOfCode.DaySeven
{
    public static class DataGetter
    {
        public static List<BagModel> GetData()
        {
            var result = new List<BagModel>();
            using (var sr = new StreamReader("../../../DaySeven/input.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var bag = new BagModel();



                    result.Add(bag);
                }
            }

            return result;
        }
    }
}