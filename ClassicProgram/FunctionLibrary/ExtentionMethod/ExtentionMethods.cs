using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLibrary.Extention_Method
{
    public static class ExtentionMethods
    {
        public static void PrintToConsole(string Message, ConsoleColor bgcolor = ConsoleColor.Cyan, ConsoleColor fgcolor = ConsoleColor.White)
        {
            Console.BackgroundColor = bgcolor;
            Console.ForegroundColor = fgcolor;
            Console.WriteLine(Message);
            Console.ResetColor();
        }
    }
}
