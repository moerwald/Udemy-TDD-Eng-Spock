using System;
using System.Collections.Generic;

namespace At.Moerwald.RomanReader
{
    public static class RomanReader
    {
        private static Dictionary<char, int> _map = new Dictionary<char, int>
        {
            { 'I' ,    1 },
            { 'V' ,    5 },
            { 'X' ,   10 },
            { 'L' ,   50 },
            { 'C' ,  100 },
            { 'D' ,  500 },
            { 'M' , 1000 }
        };

        public static int Parse(string roman)
        {
            int result = 0;

            for (var i = 0; i< roman.Length; i++)
            {
                if ((i+1) < roman.Length && 
                    (_map[roman[i]] < _map[roman[i+1]]) // Next less than actual
                   )
                {
                    result += _map[roman[i + 1]] - _map[roman[i]];
                    i++;
                }
                else
                {
                    result += _map[roman[i]];
                }
            }

            return result;
        }
    }
}
