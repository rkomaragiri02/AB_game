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

        public static bool codeMatch(string code, string guess, int A, int B)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < 4; i++)
            {
                if (code[i] == guess[i])
                {
                    a++;
                }
                else
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i != j && code[j] == guess[i] && code[j] != guess[j])
                        {
                            b++;
                            break;
                        }
                    }
                }
            }
            return a == A && b == B;
        }

        public static List<string> GenerateGuessList()
        {
            Random random = new Random();
            List<string> guessList = new List<string>(10000);

            for (int i = 0; i <= 9999; i++)
            {
                string intstring = i.ToString();
                while (intstring.Length != 4)
                {
                    intstring = "0" + intstring;
                }

                char a = intstring[0];
                char b = intstring[1];
                char c = intstring[2];
                char d = intstring[3];
                bool notUnique = a == b || a == c || a == d || b == c || b == d || c == d;

                if (notUnique)
                {
                    continue;
                }

                string intarray = intstring.ToString();
                guessList.Add(intarray);

            }

            return guessList;
        }
    }
}
