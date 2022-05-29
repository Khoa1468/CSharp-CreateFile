using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFile
{
    internal class HandlerInput
    {
        public HandlerInput()
        {
            Run();
        }

        protected void Run()
        {
            while (true)
            {
                PrintOutput.Println("Please Choose Your Option: ");
                GetLangsReturnValue Languages = GetLangs();
                foreach(KeyValuePair<string, string[]> entry in Languages.languageDic)
                {
                    PrintOutput.Println($"{entry.Key}. {entry.Value[0]}");
                }
                string CheckString = Input.GetInput("Your Choice (type 'quit' or 'exit' to exit): ");
                if (CheckString.ToLower().Equals("quit") || CheckString.ToLower().Equals("exit")) break;
                CheckInput.Check(CheckString, Languages).Run();
            }
        }

        protected GetLangsReturnValue GetLangs()
        {
            BaseLang[] languages = { new CSharpLang(), new CPPLang(), new JavaLang(), new ReactProject() };
            Dictionary<string, string[]> languagesDictionary = new Dictionary<string, string[]>();
            foreach (BaseLang language in languages)
            {
                languagesDictionary.Add(language.key, language.names);
            }

            return new GetLangsReturnValue(languages, languagesDictionary);
        }
    }
}
