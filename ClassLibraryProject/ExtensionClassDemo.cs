using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProject
{
    public static class ExtensionClassDemo
    {
        public static string ToCurrency(this string str)
        {
            if (float.TryParse(str, out float number))
            {
                return $"$ {number:N2}";
            }
            else
            {
                throw new FormatException("input string is not a number");
            }
        }
    }
}
