using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFile
{
    internal class ReactProject : BaseLang
    {
        public ReactProject() : base("4", new string[] {"React"}) { }
        public override void Run()
        {
            string ProjectName = Input.GetInput("Your Project name (no extensions): ");
            string PATH = Input.GetInput("Typing your directory to create a project (we recommend using /): ");
            string directory = PATH + "/" + ProjectName;

            string strCmdText;
            strCmdText = $"/C npx create-react-app {directory}";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
    }
}
