using System;
using System.Collections.Generic;
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
    }
}
