namespace AdventOfCode.DayEight
{
    public class InstructionModel
    {
        public int Index { get; set; }
        public string Instruction { get; set; }
        public string Direction { get; set; }
        public int Value { get; set; }
        public bool Completed { get; set; }
    }
}