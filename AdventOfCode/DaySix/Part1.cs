using System.Linq;

namespace AdventOfCode.DaySix
{
    public class Part1
    {
        public int GetAnswer()
        {
            var data = DataGetter.GetData();

            return data.AllGroupAnswers.Sum(a => a.SelectMany(a=>a.ToList()).Distinct().Count());
        }
    }
}