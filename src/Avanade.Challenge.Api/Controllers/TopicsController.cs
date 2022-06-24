using Avanade.Challenge.Api.Infra.Database.Domain;
using Avanade.Challenge.Api.Infra.Database.Repository; 
using Microsoft.AspNetCore.Mvc; 
using System.Collections.Generic; 
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Avanade.Challenge.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        private TopicRepository topicRepository;
        public TopicsController(TopicRepository _topicRepository)
        {
            topicRepository = _topicRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Topic>> GetAsync()
        {
            return await topicRepository.GetListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Topic> GetAsync(int id)
        {
            return await topicRepository.GetIndexAsync(id);
        }

        [HttpPost]
        public async Task Post([FromBody] Topic topic)
        {
            await topicRepository.SaveAsync(topic);
        }

        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Topic topic)
        {
            await topicRepository.UpdateAsync(topic);
        }
         
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await topicRepository.Delete(id);
        }
    }
}
