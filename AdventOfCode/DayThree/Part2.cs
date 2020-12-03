using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.DayThree
{
    public class Part2
    {
        private SlopeModel _slope;

        public long GetAnswer()
        {
            _slope = DataGetter.GetData();
            long answer = 1;
            var traversals = GetTraversals();
            foreach (var traversal in traversals)
            {
                var currentRow = 0;
                var currentCol = 0;
                var treesHit = 0;

                while (currentRow < _slope.Rows.Count)
                {
                    if (IsATree(currentRow, currentCol))
                    {
                        treesHit++;
                    }

                    currentCol += traversal.Right;
                    currentRow += traversal.Down;
                }

                answer = answer * treesHit;
            }

            return answer;
        }

        private bool IsATree(int currentRow, int currentCol)
        {
            return _slope.Rows[currentRow].Location[currentCol % 31] == "#";
        }

        private List<TraverseModel> GetTraversals()
        {
            return new List<TraverseModel>
            {
                new TraverseModel
                {
                     Right = 1,
                     Down = 1
                },
                new TraverseModel
                {
                     Right = 3,
                     Down = 1
                },
                new TraverseModel
                {
                     Right = 5,
                     Down = 1
                },
                new TraverseModel
                {
                     Right = 7,
                     Down = 1
                },
                new TraverseModel
                {
                     Right = 1,
                     Down = 2
                }
            };
        }
    }
}
