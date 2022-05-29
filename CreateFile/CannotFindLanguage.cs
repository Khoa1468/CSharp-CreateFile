using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFile
{
    internal class CannotFindLanguage: BaseLang
    {
        public CannotFindLanguage() : base("4", new string[] {"Cannot Find Your Language"})
        {

        }

        public override void Run()
        {
            PrintOutput.Println("Cannot Find Your Language. Try Later");
        }
    }
}
