using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFile
{
    internal class CSharpLang : BaseLang
    {
        public CSharpLang() : base("1", new string[] { "C#", "CSharp" }) { }

        public override void Run() {
            try
            {
                string Filename = Input.GetInput("Your file name (no extensions): ") + ".cs";
                string PATH = Input.GetInput("Typing your directory to create a file (we recommend using /): ");
                string directory = PATH + "/" + Filename;

                if (!Directory.Exists(PATH))
                {
                    Directory.CreateDirectory(PATH);
                }

                StreamWriter fs = new(directory);

                fs.Write("using System;\n" +
                        "\n" +
                        "namespace CSharpFile\n" +
                        "{\n" +
                        "    class Program\n" +
                        "    {\n" +
                        "        static void Main(string[] args)\n" +
                        "        {\n" +
                        "            string message = \"Hello World!!\";\n" +
                        "\n" +
                        "            Console.WriteLine(message);\n" +
                        "        }\n" +
                        "    }\n" +
                        "}");
                fs.Close();
            } catch (IOException e)
            {
                PrintOutput.Print(e.StackTrace);
                Environment.Exit(1);
            }
        }
    }
}
