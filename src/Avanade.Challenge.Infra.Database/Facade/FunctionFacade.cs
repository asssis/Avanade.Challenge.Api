using Avanade.Challenge.Infra.Database.Facade.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avanade.Challenge.Infra.Database.Facade
{
    public class FunctionFacade : IFunctionFacade
    { 
        public string TakeOutBlankSpace(string phrase)
        {
            phrase = phrase.Replace(" ", "");
            phrase = phrase.Replace(",", "");
            phrase = phrase.Replace(".", "");
            phrase = phrase.Replace("!", "");
            phrase = phrase.Replace("?", "");
            phrase = phrase.Replace("/", "");
            return phrase.ToLower();

        } 
    }
}
