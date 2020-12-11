using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode.DayEight
{
    public class Part2
    {
        private int _answer;
        private List<InstructionModel> _data;

        public int GetAnswer()
        {
            _data = DataGetter.GetData();
            for (int i = 0; i < _data.Count; i++)
            {
                _answer = 0;
                SwitchInstruction(_data[i]);
                ProcessInstruction(_data[0]);
                if (_data[_data.Count - 1].Completed)
                {
                    return _answer;
                }
                SwitchInstruction(_data[i]);
                _data.ForEach(a => a.Completed = false);
            }

            return _answer;
        }

        private void SwitchInstruction(InstructionModel instruction)
        {
            if (instruction.Instruction == "jmp")
            {
                instruction.Instruction = "nop";
            }
            else if (instruction.Instruction == "nop")
            {
                instruction.Instruction = "jmp";
            }
        }

        private void ProcessInstruction(InstructionModel instruction)
        {
            if (instruction.Completed) return;

            InstructionModel nextInstruction;
            switch (instruction.Instruction)
            {
                case "acc":
                    _answer += instruction.Direction == "+" ? instruction.Value : -instruction.Value;
                    nextInstruction = _data.FirstOrDefault(a => a.Index == instruction.Index + 1);
                    break;
                case "jmp":
                    var nextIndex = instruction.Index + (instruction.Direction == "+" ? instruction.Value : -instruction.Value);
                    nextInstruction = _data.FirstOrDefault(a => a.Index == nextIndex);
                    break;
                case "nop":
                    nextInstruction = _data.FirstOrDefault(a => a.Index == instruction.Index + 1);
                    break;
                default:
                    throw new InvalidDataException("Invalid data at index " + instruction.Index);
            }

            instruction.Completed = true;
            if (nextInstruction != null)
            {
                ProcessInstruction(nextInstruction);
            }
        }
    }
}