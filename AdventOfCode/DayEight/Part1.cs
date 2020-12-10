using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.DayEight
{
    public class Part1
    {
        private int _answer;
        private List<InstructionModel> _data;

        public int GetAnswer()
        {
            _data = DataGetter.GetData();
            ProcessInstruction(_data[0]);

            return _answer;
        }

        private void ProcessInstruction(InstructionModel instruction)
        {
            if (instruction.Completed) return;

            InstructionModel nextInstruction;
            switch (instruction.Instruction)
            {
                case "acc":
                    _answer += instruction.Direction == "+" ? instruction.Value : -instruction.Value;
                    nextInstruction = _data.First(a => a.Index == instruction.Index + 1);
                    break;
                case "jmp":
                    var nextIndex = instruction.Index + (instruction.Direction == "+" ? instruction.Value : -instruction.Value);
                    nextInstruction = _data.First(a => a.Index == nextIndex);
                    break;
                case "nop":
                    nextInstruction = _data.First(a => a.Index == instruction.Index + 1);
                    break;
                default:
                    throw new InvalidDataException("Invalid data at index " + instruction.Index);
            }

            instruction.Completed = true;
            ProcessInstruction(nextInstruction);
        }
    }
}