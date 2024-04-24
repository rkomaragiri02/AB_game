using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3433
{
    public class CodebreakerHelper
    {
        public static int calculateScore(int totalTries, int totalSecondsTaken)
        {
            int gameScore = 10 * (10 - totalTries + 1) - (totalSecondsTaken / 10);

            return gameScore;
        }

        public static bool codeMatch(string c1, string c2, int ACount, int BCount)
        {
            int a = 0;
            int b = 0;

            for (int i = 0; i < 4; i++)
            {
                if (c1[i] == c2[i]) a++;
                else if (c2.Contains(c1[i]) && c2[i] != c1[i]) b++;
            }

            return a == ACount && b == BCount;
        }
    }
}
