using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.DayThree
{
    public class SlopeModel
    {
        public SlopeModel()
        {
            Rows = new List<SlopeRow>();
        }
        public List<SlopeRow> Rows { get; set; }
    }
}
