using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Stack
{
    public class Palindrom
    {
        public static bool CheckPalindrom(string input)
        {
            Stack<char> PalindromStack = new Stack<char>(input);

            foreach (char c in input)
            {
                if (PalindromStack.Pop() != c)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
