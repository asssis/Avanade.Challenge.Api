using System.Collections.Generic;
using System.Threading.Tasks;
using Avanade.Challenge.Api.Infra.Database.Domain;
using Avanade.Challenge.Infra.Database;
using Avanade.Challenge.Infra.Database.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Avanade.Challenge.Api.Infra.Database.Repository
{
    public class TopicRepository : ITopicRepository
    {
        private readonly AppContexto appContexto;
        public TopicRepository(AppContexto _appContexto)
        {
            appContexto = _appContexto;
        }
        public TopicRepository() { }
        public async Task<IEnumerable<Topic>> GetListAsync()
        { 
            return await appContexto.Topics.ToListAsync();
        }

        public async Task<Topic> GetIndexAsync(int id)
        {
            return await appContexto.Topics.FirstOrDefaultAsync(x => x.Id == id); 
        }

        public async Task<int> SaveAsync(Topic topic)
        {
            appContexto.Add(topic);
            return await appContexto.SaveChangesAsync();  
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
        public Topic Teste(int id)
        {
            return new Topic("sdfsdf");
        } 
    }
}
