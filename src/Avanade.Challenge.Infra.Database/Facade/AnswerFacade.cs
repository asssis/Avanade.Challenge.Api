using Avanade.Challenge.Api.Infra.Database.Domain;
using Avanade.Challenge.Infra.Database.Facade.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avanade.Challenge.Infra.Database.Facade
{
    public class AnswerFacade : IAnswerFacade
    {
        private readonly ICheckFacade checkFacade;
        private readonly ICheckComplexFacade checkComplex;
        public AnswerFacade()
        {
            checkFacade = new CheckFacade();
        }
        public bool CheckFrase(Phrase phrase, string answer)
        {
            bool resultado = checkFacade.Check(phrase, answer);

            if(resultado)
                resultado = checkComplex.Check(phrase, answer);

            return resultado;
        }

    }
}
