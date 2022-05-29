using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFile
{
    internal class Input
    {
        public static string GetInput(string? defaultPrintString = "")
        {
            PrintOutput.Print(defaultPrintString ?? "");
            return Console.ReadLine() ?? "";
        }
    }
}
