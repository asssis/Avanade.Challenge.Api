using Avanade.Challenge.Api.Infra.Database.Domain;
using Avanade.Challenge.Api.Infra.Database.Repository; 
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Avanade.Challenge.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhrasesController : ControllerBase
    {
        private PhraseRepository phraseRepository;
        public PhrasesController(PhraseRepository _phraseRepository)
        {
            phraseRepository = _phraseRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Phrase>> GetAsync()
        {

            return await phraseRepository.GetListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Phrase> GetAsync(int id)
        {
            return await phraseRepository.GetIndexAsync(id);
        }

        [HttpPost]
        public async Task Post([FromBody] Phrase phrase)
        {
            await phraseRepository.SaveAsync(phrase);
        }

        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Phrase phrase)
        {
            await phraseRepository.UpdateAsync(phrase);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await phraseRepository.Delete(id);
        }
    }
}
