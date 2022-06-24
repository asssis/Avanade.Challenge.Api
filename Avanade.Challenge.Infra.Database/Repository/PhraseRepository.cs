using Avanade.Challenge.Api.Infra.Database.Domain;
using Avanade.Challenge.Infra.Database;
using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avanade.Challenge.Api.Infra.Database.Repository
{
    public class PhraseRepository
    {
        private readonly AppContexto appContexto;
        public PhraseRepository(AppContexto _appContexto)
        {
            appContexto = _appContexto;
        }

        public async Task<IEnumerable<Phrase>> GetListAsync()
        {
            return await appContexto.Phrases.ToListAsync();
        }

        public async Task<Phrase> GetIndexAsync(int id)
        {
            return await appContexto.Phrases.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task SaveAsync(Phrase topic)
        {
            appContexto.Add(topic);
            await appContexto.SaveChangesAsync();
        }

        public async Task UpdateAsync(Phrase topic)
        {
            var entity = await appContexto.Phrases.FirstOrDefaultAsync(c => c.Id == topic.Id);
            if (entity == null)
            {
                return;
            }

            appContexto.Entry(entity).CurrentValues.SetValues(topic);
        }

        public async Task Delete(int id)
        {
            var entity = await appContexto.Phrases.FirstOrDefaultAsync(c => c.Id == id);
            if (entity == null)
            {
                return;
            }
            appContexto.Phrases.Remove(entity);
        }
    }
}