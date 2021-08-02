using System;
using System.Collections.Generic;
using System.Text;

namespace ApiSample
{
    public static class StringManupulationExtensions
    {
        public static string ToCamel(this string stringToCamel) 
        {
            List<char> letters = new();
            for(int c = 0; c != stringToCamel.Length; c++) 
            {
                letters.Add(stringToCamel[c]);
            }

            StringBuilder builder = new();
            for(int letterIndex = 0; letterIndex != letters.Count; letterIndex++) 
            {
                if(letterIndex % 2 == 0)
                    builder.Append(Char.ToUpper(letters[letterIndex]));
                else builder.Append(letters[letterIndex]);
            }

            return builder.ToString();
        }
    }
}