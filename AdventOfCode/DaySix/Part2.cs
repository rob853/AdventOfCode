using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.DaySix
{
    public class Part2
    {
        public int GetAnswer()
        {
            var data = DataGetter.GetData();
            var result = 0;

            foreach (var group in data.AllGroupAnswers)
            {
                var allYesForGroup = new List<char>();

                foreach (var personsAnswers in group)
                {
                    foreach (var answer in personsAnswers)
                    {
                        if (group.SelectMany(a => a.ToList()).Count(b => b == answer) >= group.Count &&
                            !allYesForGroup.Contains(answer))
                        {
                            allYesForGroup.Add(answer);
                        }
                    }
                }

                result += allYesForGroup.Count();
            }

            return result;
        }
    }
}