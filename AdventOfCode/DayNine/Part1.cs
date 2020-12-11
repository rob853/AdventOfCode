using System.Collections.Generic;
namespace AdventOfCode.DayNine
{
    public class Part1
    {
        private List<long> _data;
        private const int preambleLength = 25;

        public long GetAnswer()
        {           
            _data = DataGetter.GetData();

            for (int i = preambleLength; i < _data.Count; i++)
            {                
                if (!PreviousValuesAddUp(i, preambleLength))
                {
                    return _data[i];
                }
            }

            return 0;
        }

        private bool PreviousValuesAddUp(int index, int previousLength)
        {
            var valueToCheck = _data[index];
            var previousValues = new List<long>();
            for (int i = (index - previousLength); i < index; i++)
            {
                previousValues.Add(_data[i]);
            }

            foreach (var firstVal in previousValues)
            {
                foreach (var secondVal in previousValues)
                {
                    if(firstVal + secondVal == valueToCheck && firstVal != secondVal){
                        return true;
                    }
                }
            }

            return false;
        }
    }
}