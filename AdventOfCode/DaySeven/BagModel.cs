using System.Collections.Generic;

namespace AdventOfCode.DaySeven
{
    public class BagModel
    {
        public string Name { get; set; }    

        public List<ChildBagModel> ChildBags { get; set; }    
    }
}