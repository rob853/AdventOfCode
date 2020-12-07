using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.DayFive
{
    public class Part2
    {
        public double GetAnswer()
        {
            var data = DataGetter.GetData();
            var allSeatIds = new List<double>();

            foreach (var planeRow in data)
            {
                allSeatIds.Add(GetRow(planeRow.PlaneRow) * 8 + GetRow(planeRow.PlaneColumn));
            }

            allSeatIds.Sort();

            for (int i = 0; i < allSeatIds.Count; i++)
            {
                if (allSeatIds[i] != i + 6)
                {
                    return i + 6;
                }
            }

            return 0;
        }

        private double GetRow(string planeCode)
        {
            double hiNum = (Math.Pow(2, planeCode.Length) - 1);
            double loNum = 0;

            foreach (var rowChar in planeCode)
            {
                var diff = hiNum - loNum;

                if (rowChar == 'F' || rowChar == 'L')
                {
                    hiNum -= (diff + 1) / 2;
                }
                else
                {
                    loNum += (diff + 1) / 2;
                }
            }

            return hiNum;
        }
    }
}