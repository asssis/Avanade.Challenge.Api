using System.Collections.Generic;
using System.Threading.Tasks;
using Avanade.Challenge.Api.Infra.Database.Domain;
using Avanade.Challenge.Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Avanade.Challenge.Api.Infra.Database.Repository
{
    public class TopicRepository
    {
        private readonly AppContexto appContexto;
        public TopicRepository(AppContexto _appContexto)
        {
            appContexto = _appContexto;
        }
        public async Task<IEnumerable<Topic>> GetListAsync()
        { 
            return await appContexto.Topics.ToListAsync();
        }

        public async Task<Topic> GetIndexAsync(int id)
        {
            return await appContexto.Topics.FirstOrDefaultAsync(m => m.Id == id); 
        }

        public async Task SaveAsync(Topic topic)
        {
            appContexto.Add(topic);
            await appContexto.SaveChangesAsync();  
        }

        public async Task UpdateAsync(Topic topic)
        { 
            var entity = await appContexto.Topics.FirstOrDefaultAsync(c => c.Id == topic.Id);
            if (entity == null)
            {
                return;
            }

            appContexto.Entry(entity).CurrentValues.SetValues(topic); 
        }

        public async Task Delete(int id)
        {
            var entity = await appContexto.Topics.FirstOrDefaultAsync(c => c.Id == id);
            if (entity == null)
            {
                return;
            }
            appContexto.Topics.Remove(entity);
        }
    }
}
