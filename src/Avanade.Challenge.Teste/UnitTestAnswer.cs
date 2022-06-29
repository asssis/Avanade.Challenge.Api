using Avanade.Challenge.Api.Infra.Database.Domain;
using Avanade.Challenge.Api.Infra.Database.Repository;
using Avanade.Challenge.Infra.Database;
using Avanade.Challenge.Infra.Database.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Avanade.Challenge.Teste
{
    public class UnitTestAnswer
    {
        readonly PhraseRepository phraseRepository;

        public UnitTestAnswer()
        {
            phraseRepository = new PhraseRepository(new AppContexto());
        }

        [Fact(DisplayName = "Verificando Answer Facade")]
        public void CheckIfOk()
        {
            string respota = "test kayak";
            Phrase phrase = new Phrase(0, null) { Expression = "test kayak" };

            bool result = phraseRepository.CheckPhrase(phrase, respota);
            Assert.True(result);
        }


        [Fact(DisplayName = "Verificando Com Letras Diferente Fim")]
        public void CheckIfOkLastError()
        {
            string respota = "test kayakk";
            Phrase phrase = new Phrase(0, null) { Expression = "test kayak" };

            bool result = phraseRepository.CheckPhrase(phrase, respota);
            Assert.True(result);
        }

        [Fact(DisplayName = "Verificando Error Com Letras Diferentes Inicio")]
        public void CheckIfOkMiddleError()
        {
            string respota = "test kkayak";
            Phrase phrase = new Phrase(0, null) { Expression = "test kayak" };

            bool result = phraseRepository.CheckPhrase(phrase, respota);
            Assert.True(result);
        }

        [Fact(DisplayName = "Verificando Erro Com Letras Diferentes")]
        public void CheckIfOkMiddleErrorOnLetter()
        {
            string respota = "test kaoak";
            Phrase phrase = new Phrase(0, null) { Expression = "test kayak" };

            bool result = phraseRepository.CheckPhrase(phrase, respota);
            Assert.True(result);
        }

        [Fact(DisplayName = "Verificando Erro Com Sensitive")]
        public void CheckIfOkMiddleErrorOnLetterUpcase()
        {
            string respota = "test KAYAK";
            Phrase phrase = new Phrase(0, null) { Expression = "test kayak" };

            bool result = phraseRepository.CheckPhrase(phrase, respota);
            Assert.True(result);
        }

        [Fact(DisplayName = "Verificando Answer Com Caracteres Especiais")]
        public void CheckIfOkErrorCharactere()
        {
            string respota = "test KAYAK";
            Phrase phrase = new Phrase(0, null) { Expression = "test, kayak" };

            bool result = phraseRepository.CheckPhrase(phrase, respota);
            Assert.True(result);
        }

        [Fact(DisplayName = "Verificando Erros")]
        public void CheckIfErrorCharactere()
        {
            string respota = "aest, bayal";
            Phrase phrase = new Phrase(0, new Topic("")) {Expression = "test, kayak" };

            bool result = phraseRepository.CheckPhrase(phrase, respota);
            Assert.False(result);
        }
    }
}
