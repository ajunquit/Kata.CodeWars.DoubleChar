using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.CodeWars.DoubleChar
{
    public static class Kata
    {
        public static string DoubleChar(string s)
        {
            var characters = s.ToArray();
            string response = string.Empty;
            
            foreach (char c in characters)
                response += c.ToString() + c.ToString();
            
            return response;
        }
    }
}
