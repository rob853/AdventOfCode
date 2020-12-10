using System.Collections.Generic;
using System.IO;

namespace AdventOfCode.DayEight
{
    public static class DataGetter
    {
        public static List<InstructionModel> GetData()
        {
            var result = new List<InstructionModel>();
            using (var sr = new StreamReader("./DayEight/input.txt"))
            {
                string line;
                var index = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    var instruction = new InstructionModel();
                    instruction.Index = index;
                    instruction.Instruction = line.Substring(0, 3);
                    instruction.Direction = line.Substring(4, 1);
                    instruction.Value = int.Parse(line.Substring(5));
                    index++;
                    result.Add(instruction);
                }
            }

            return result;
        }
    }
}