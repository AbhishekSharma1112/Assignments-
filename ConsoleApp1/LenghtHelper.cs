using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LenghtHelper
    {
          public int findlenght(string? word)
            {
                if (word != null)
                    return word.Length;
                else 
                   throw new Exception("Please enter value");


            }

    }
}

