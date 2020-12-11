using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.DayNine
{
    public class Part2
    {
        private long _firstAnswer;
        private List<long> _data;

        public long GetAnswer()
        {
            _firstAnswer = new Part1().GetAnswer();
            _data = DataGetter.GetData();

            for (int i = 0; i < _data.Count; i++)
            {
                var weakness = GetEncryptionWeakness(i);
                if (weakness > 0) return weakness;
            }

            return 0;
        }

        private long GetEncryptionWeakness(int index)
        {
            long total = 0;
            var startNum = _data[index];
            var checkedValues = new List<long>();

            while (total <= _firstAnswer)
            {
                checkedValues.Add(_data[index]);
                total += _data[index];
                if(total == _firstAnswer) return checkedValues.Min() + checkedValues.Max();
                index++;
            }

            return 0;
        }
    }
}