using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFile
{
    internal class PrintOutput
    {
        public static void Print<T>(T? value)
        {
            Console.Write(value);
        }
        public static void Print<T>()
        {
            Console.Write("");
        }
        public static void Print()
        {
            Console.Write("");
        }
        public static void Println<T>(T? value)
        {
            Console.WriteLine(value);
        }
        public static void Println<T>()
        {
            Console.WriteLine("");
        }
        public static void Println()
        {
            Console.WriteLine("");
        }
    }
}
