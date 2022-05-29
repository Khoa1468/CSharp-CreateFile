using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFile
{
    internal abstract class BaseLang
    {
        public readonly string key;
        public readonly string[] names;
        public abstract void Run();
        public BaseLang(string argsKey, string[] argsNames)
        {
            key = argsKey;
            names = argsNames;
        }
    }
}
