using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFile
{
    internal class CPPLang: BaseLang
    {
        public CPPLang() : base("2", new string[] {"C++", "CPP"}) { }
        public override void Run()
        {
            try
            {
                string Filename = Input.GetInput("Your file name (no extensions): ") + ".cpp";
                string PATH = Input.GetInput("Typing your directory to create a file (we recommend using /): ");
                string directory = PATH + "/" + Filename;

                if (!Directory.Exists(PATH))
                {
                    Directory.CreateDirectory(PATH);
                }

                StreamWriter fs = new(directory);

                fs.Write($"#include <iostream>\n" +
                    $"\n" +
                    $"using namespace std;\n" +
                    $"\n" +
                    $"int main() {{\n" +
                    $"    cout << \"Hello, World!\";\n" +
                    $"}}");
                fs.Close();
            }
            catch (IOException e)
            {
                PrintOutput.Print(e.StackTrace);
                Environment.Exit(1);
            }
        }
    }
}
