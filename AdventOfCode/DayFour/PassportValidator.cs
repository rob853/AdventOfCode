using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.DayFour
{
    public static class PassportValidator
    {
        public static int GetValidPassportCount(List<PassportModel> passports)
        {
            return passports.Count(a => IsValid(a));
        }

        private static bool IsValid(PassportModel passport)
        {
            return !string.IsNullOrEmpty(passport.BirthYear) &&
                   !string.IsNullOrEmpty(passport.ExpirationYear) &&
                   !string.IsNullOrEmpty(passport.EyeColor) &&
                   !string.IsNullOrEmpty(passport.HairColor) &&
                   !string.IsNullOrEmpty(passport.Height) &&
                   !string.IsNullOrEmpty(passport.IssueYear) &&
                   !string.IsNullOrEmpty(passport.PassportId);
        }
    }
}