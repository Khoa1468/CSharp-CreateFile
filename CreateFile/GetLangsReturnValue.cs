using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFile
{
    internal class GetLangsReturnValue
    {
        public BaseLang[] languages;
        public Dictionary<string, string[]> languageDic;
        public GetLangsReturnValue(BaseLang[] langs, Dictionary<string, string[]> dic)
        {
            languages = langs;
            languageDic = dic;
        }
    }
}
