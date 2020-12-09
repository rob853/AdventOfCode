using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.DaySeven
{
    public class Part1
    {
        private string _inputName = "shiny gold";
        private List<BagModel> _data;

        public int GetAnswer()
        {
            _data = DataGetter.GetData();
            var result = 0;

            foreach (var bag in _data)
            {
                if (CheckBag(bag.Name) && bag.Name != _inputName)
                {
                    result++;
                }
            }

            return result;
        }

        private bool CheckBag(string bagName)
        {
            if (bagName == _inputName) return true;
            if (bagName == "no more bags") return false;
            var bag = _data.First(a => a.Name == bagName);
            var result = false;

            foreach (var childBag in bag.ChildBags)
            {
                if (CheckBag(childBag.Name))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}