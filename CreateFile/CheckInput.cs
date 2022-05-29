using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFile
{
    internal class CheckInput
    {
        public static BaseLang Check(string CheckString, GetLangsReturnValue LangsData)
        {
            BaseLang LanguageResult = new CannotFindLanguage();
            foreach (BaseLang lang in LangsData.languages)
            {
                if (CheckString == "") break;
                else if (lang.key.Contains(CheckString))
                {
                    LanguageResult = lang;
                }
            }

            return LanguageResult;
        }
    }
}
