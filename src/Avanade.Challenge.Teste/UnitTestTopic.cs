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
    public class UnitTestTopic
    {
        private readonly Mock<AppContexto> appContexto;
        private readonly Mock<ITopicRepository> mockTopicRepository;
        private readonly TopicRepository topicRepository; 
        public UnitTestTopic()
        { 
            appContexto = new Mock<AppContexto>();
            mockTopicRepository = new Mock<ITopicRepository>();
            topicRepository = new TopicRepository();
        }
          
        [Theory(DisplayName = "Verificando topic alvo no banco")]
        [InlineData("head",1)]
        [InlineData("very", 1)]
        [InlineData("strong", 1)]
        public async Task CheckSaveTopicBankAsync(string descricao, int id)
        {
            var topic = new Topic(descricao);
            topic.Id = id;

            mockTopicRepository.Setup(x => x.SaveAsync(topic)).ReturnsAsync(id);

            var result = await mockTopicRepository.Object.SaveAsync(topic);
            Assert.Equal(result, topic.Id);
        }

        [Theory(DisplayName = "Verificando Topicos Salvos")]
        [InlineData(1)]
        public async Task GetTopicBankAsync(int id)
        { 
            mockTopicRepository.Setup(x => x.GetIndexAsync(It.IsAny<int>())).ReturnsAsync(new Topic("stop") { Id = id });
            var result = await mockTopicRepository.Object.GetIndexAsync(id);
            
            Assert.Equal(result.Id, id);
        }

        [Fact(DisplayName = "Verificando Topicos Salvos")]
        public void ListTopicsBank()
        {
            var listTopics = new List<Topic>()
            {
                new Topic("Home"){ Id = 1 },
                new Topic("Office"){ Id = 2},
                new Topic("Window"){ Id = 3}
            };
            int total = 3;

            mockTopicRepository.Setup(x => x.GetListAsync()).ReturnsAsync(listTopics);
            var result = mockTopicRepository.Object.GetListAsync().Result;

            Assert.Equal(result.Count(), total);
        }

    }
}
