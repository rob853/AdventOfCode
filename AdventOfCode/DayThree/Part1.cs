namespace AdventOfCode.DayThree
{
    public class Part1
    {
        private SlopeModel _slope;

        public int GetAnswer()
        {
            _slope = DataGetter.GetData();
            var currentRow = 0;
            var currentCol = 0;
            var treesHit = 0;

            while(currentRow < _slope.Rows.Count)
            {
                if(IsATree(currentRow, currentCol))
                {
                    treesHit++;
                }

                currentCol += 3;
                currentRow += 1;
            }

            return treesHit;
        }

        private bool IsATree(int currentRow, int currentCol)
        {
            return _slope.Rows[currentRow].Location[currentCol % 31] == "#";
        }
    }
}
