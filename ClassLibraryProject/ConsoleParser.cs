using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryProject
{
    public class ConsoleParser
    {
        private Action<string> onWord;
        private Action<string> onNumber;
        private Action<string> onJunk;

        public ConsoleParser(Action<string> onWord, Action<string> onNumber , Action<string> onJunk) { 
            this.onWord = onWord;
            this.onNumber = onNumber;
            this.onJunk = onJunk;
        }

        public void Run()
        {
            while(true)
            {
                string input = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                if (IsWord(input))
                {
                    onWord?.Invoke(input);
                }else if(IsNumber(input))
                {
                    onNumber?.Invoke(input);    
                }else
                {
                    onJunk?.Invoke(input);
                }
                
            }
        }

        private bool IsWord(string input)
        {
            bool isWord = false;
            if (Regex.IsMatch(input, "[A-Za-z]") && Regex.IsMatch(input, "[0-9]"))
            {
                isWord = true;
            }
            if(Regex.IsMatch(input, @"^[A-Za-z]+$"))
            {
                isWord = true;
            }

            return isWord;
        }

        private bool IsNumber(string input)
        {
            return Regex.IsMatch(input, @"[0-9]+$");
        }
    }
}
