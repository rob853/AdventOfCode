using System.Collections.Generic;
using System.IO;

namespace AdventOfCode.DaySix
{
    public static class DataGetter
    {
        public static CustomsFormModel GetData()
        {
            var result = new CustomsFormModel()
            {
                AllGroupAnswers = new List<List<string>>()
            };

            using (var sr = new StreamReader("./DaySix/input.txt"))
            {
                var listToAdd = new List<string>();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrEmpty(line))
                    {
                        result.AllGroupAnswers.Add(listToAdd);
                        listToAdd = new List<string>();
                    }
                    else
                    {
                        listToAdd.Add(line);
                    }

                }

                result.AllGroupAnswers.Add(listToAdd);
            }

            return result;
        }
    }
}