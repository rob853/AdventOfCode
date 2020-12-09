using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.DaySeven
{
    public class Part2
    {
        private string _inputName = "shiny gold";
        private List<BagModel> _data;

        public int GetAnswer()
        {
            _data = DataGetter.GetData();
            var result = GetTotalBagsContained(_inputName);           
           
            return result;
        }

        private int GetTotalBagsContained(string inputName)
        {
            var bag = _data.First(a => a.Name == inputName);
            var totalCount = inputName == _inputName ? 0 : 1;
            totalCount += bag.ChildBags.Sum(a => a.Quantity * GetTotalBagsContained(a.Name));

            return totalCount;
        }
    }
}