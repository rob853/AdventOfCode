using System;
using System.Linq;

namespace AdventOfCode.DayFive
{
    public class Part1
    {
        public double GetAnswer()
        {
            var data = DataGetter.GetData();
            double result = 0;

            foreach (var planeRow in data)
            {
                var row = GetRow(planeRow.PlaneRow);
                var col = GetRow(planeRow.PlaneColumn);
                var res = row * 8 + col;
                if (res > result)
                {
                    result = res;
                }
                System.Console.WriteLine(res);
            }

            return result;
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