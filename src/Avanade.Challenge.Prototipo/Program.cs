using System;
using System.Collections.Generic;

namespace Avanade.Challenge.Prototipo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string frase = @"assis teste hhh adf";
            string resposta = @"asssis teste hhhh abf";
            VerificarFrase(frase, resposta);
        }

        public static List<int> VerificarFrase(string frase, string resposta)
        {
            string[] wordPhrase = frase.Split(" ");
            string[] wordAnswer = resposta.Split(" ");
            List<int> verificacao = new List<int>();

            for (int i = 0; i < wordPhrase.Length; i++)
            {
                int checkinWord = VerificarPalavras(wordPhrase[i], wordAnswer[i]);
                if (checkinWord == 0)
                    verificacao.Add(0);
                else if(checkinWord == 1)
                    verificacao.Add(1);
                else
                    verificacao.Add(2);
            }
            return verificacao;
        }

        public static int VerificarPalavras(string fr, string ans)
        {
            List<bool> val_asc = new List<bool>();
            List<bool> val_desc = new List<bool>();

            for (int i = 0; i < fr.Length; i++)
            {
                val_asc.Add(ans[i] == fr[i]);
                if(ans.Length > i)
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
