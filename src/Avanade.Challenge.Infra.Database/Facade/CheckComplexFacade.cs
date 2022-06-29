using Avanade.Challenge.Api.Infra.Database.Domain;
using Avanade.Challenge.Infra.Database.Facade.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avanade.Challenge.Infra.Database.Facade
{
    public class CheckComplexFacade : ICheckComplexFacade
    {
        private readonly IFunctionFacade functionFacade;

        public CheckComplexFacade()
        {
            functionFacade = new FunctionFacade();
        }

        public bool Check(Phrase phrase, string answer)
        { 
            List<int> checkinWords = VerificarFrase(phrase.Expression, answer);

            int teste = checkinWords.FindAll(x => x != 0 || x == 1).Count;
            if (checkinWords.FindAll(x => x != 0 || x == 1).Count > 0)
                return false; 

            return true;
        }


        private List<int> VerificarFrase(string frase, string resposta)
        {
            string[] wordPhrase = frase.Split(" ");
            string[] wordAnswer = resposta.Split(" ");
            List<int> verificacao = new List<int>();

            for (int i = 0; i < wordPhrase.Length; i++)
            {
                int checkinWord = 3;
                if (wordAnswer.Length > i)
                    checkinWord = VerificarPalavras(wordPhrase[i], wordAnswer[i]);

                if (checkinWord < 2) 
                    verificacao.Add(checkinWord);
                else
                    verificacao.Add(2);
            }
            return verificacao;
        }

        private int VerificarPalavras(string fr, string ans)
        {
            List<bool> val_asc = new List<bool>();
            List<bool> val_desc = new List<bool>();

            for (int i = 0; i < fr.Length; i++)
            {
                val_asc.Add(ans[i] == fr[i]);
                if (ans.Length > i)
                    val_desc.Add(ans[ans.Length - (i + 1)] == fr[fr.Length - (i + 1)]);
            }

            val_desc.Reverse();

            List<bool> equilibrar = new List<bool>();
            for (int i = 0; i < val_asc.Count; i++)
            {
                equilibrar.Add(val_asc[i] || val_desc[i]);
            }

            List<bool> equilibrarCount = equilibrar.FindAll(x => x == false);


            if (val_asc.FindAll(x => x == false).Count == 0)
                return 0;
            else if (equilibrar.FindAll(x => x == false).Count == 0)
                return 1;
            return equilibrar.FindAll(x => x == false).Count;
        }
    }
}
