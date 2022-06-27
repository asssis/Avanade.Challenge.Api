using Avanade.Challenge.Api.Infra.Database.Domain;
using Avanade.Challenge.Infra.Database.Facade.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avanade.Challenge.Infra.Database.Facade
{
    public class CheckFacade : ICheckFacade
    {
        private readonly IFunctionFacade functionFacade;

        public CheckFacade()
        {
            functionFacade = new FunctionFacade();
        }

        public bool Check(Phrase phrase, string answer)
        { 
            string phrase_format = functionFacade.TakeOutBlankSpace(phrase.Expression);
            string answer_format = functionFacade.TakeOutBlankSpace(answer);

            return phrase_format == answer_format;
        }
    }
}
