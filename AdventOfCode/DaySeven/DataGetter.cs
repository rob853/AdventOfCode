using System.Collections.Generic;
using System.IO;

namespace AdventOfCode.DaySeven
{
    public static class DataGetter
    {
        public static List<BagModel> GetData()
        {
            var result = new List<BagModel>();
            using (var sr = new StreamReader("./DaySeven/input.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var bag = new BagModel();
                    bag.Name = line.Split(' ')[0] + " " + line.Split(' ')[1];
                    bag.ChildBags = new List<ChildBagModel>();

                    var childBagArray = line.Split("contain ")[1].Split(", ");
                    foreach (var childBagString in childBagArray)
                    {
                        if(childBagString != "no other bags.")
                        {
                            var childBag = new ChildBagModel();
                            childBag.Quantity = int.Parse(childBagString.Split(' ')[0]);
                            childBag.Name = childBagString.Split(' ')[1] + " " + childBagString.Split(' ')[2];
                            bag.ChildBags.Add(childBag);
                        }
                    }

                    result.Add(bag);
                }
            }

            return result;
        }
    }
}