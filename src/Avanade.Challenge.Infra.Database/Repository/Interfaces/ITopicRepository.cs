using Avanade.Challenge.Api.Infra.Database.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.Challenge.Infra.Database.Repository.Interfaces
{
    public interface ITopicRepository
    {
        public Task<IEnumerable<Topic>> GetListAsync();
        public Task<Topic> GetIndexAsync(int id);
        public Task<int> SaveAsync(Topic topic);
        public Task UpdateAsync(Topic topic);
        public Task Delete(int id);
        public Topic Teste(int id);
    }
}
