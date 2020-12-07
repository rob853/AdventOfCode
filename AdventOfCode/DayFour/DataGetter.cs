using System.Collections.Generic;
using System.IO;

namespace AdventOfCode.DayFour
{
    public static class DataGetter
    {
        public static List<PassportModel> GetData()
        {
            var result = new List<PassportModel>();
            using (var sr = new StreamReader("../../../DayFour/input.txt"))
            {
                string line;
                var passport = new PassportModel();
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == string.Empty)
                    {
                        result.Add(passport);
                        passport = new PassportModel();
                    }
                    else
                    {
                        var dataItems = line.Split(" ");
                        foreach (var dataItem in dataItems)
                        {
                            SetDataItem(dataItem, passport);
                        }
                    }
                }

                result.Add(passport);
            }

            return result;
        }

        private static void SetDataItem(string dataItem, PassportModel passport)
        {
            var key = dataItem.Split(":")[0];
            var val = dataItem.Split(":")[1];

            switch (key)
            {
                case "byr":
                    passport.BirthYear = val;
                    return;
                case "iyr":
                    passport.IssueYear = val;
                    return;
                case "eyr":
                    passport.ExpirationYear = val;
                    return;
                case "hgt":
                    passport.Height = val;
                    return;
                case "hcl":
                    passport.HairColor = val;
                    return;
                case "ecl":
                    passport.EyeColor = val;
                    return;
                case "pid":
                    passport.PassportId = val;
                    return;
                case "cid":
                    passport.CountryId = val;
                    return;
                default:
                    return;
            }
        }
    }
}
