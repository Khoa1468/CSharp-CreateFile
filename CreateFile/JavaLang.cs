using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFile
{
    internal class JavaLang : BaseLang
    {
        public JavaLang() : base("3", new string[] {"Java"}) { }
        public override void Run()
        {
            try
            {
                string ClassName = Input.GetInput("Your file name (no extensions, we recommend using uppercase name): ");
                string Filename = ClassName + ".java";
                string PATH = Input.GetInput("Typing your directory to create a file (we recommend using /): ");
                string directory = PATH + "/" + Filename;

                if (!Directory.Exists(PATH))
                {
                    Directory.CreateDirectory(PATH);
                }

                StreamWriter fs = new(directory);

                fs.Write($"class {ClassName} {{\n" +
                    $"    public static void main(String[] args) {{\n" +
                    $"        System.out.println(\"Hello, World!\"); \n" +
                    $"    }}\n" +
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
