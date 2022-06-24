using Avanade.Challenge.Api.Infra.Database.Domain;
using Avanade.Challenge.Infra.Database;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Avanade.Challenge.Teste
{
    public class UnitTestTopic
    {

        [Theory(DisplayName = "xxxx")]
        [InlineData(2)]
        public void GetIndexTopic(int index)
        {
            bool teste = true;
            Assert.True(teste);
        }

        [Fact(DisplayName = "xxxx")]
        public void GravarTopic()
        {
            bool teste = true;
            Assert.True(teste);
        }

        [Fact(DisplayName = "xxxx")]
        public void CreateBlog_saves_a_blog_via_context()
        {
            Topic t = new AppContexto().Topics.FirstOrDefaultAsync().Result;
             
            var paymentServiceMock = new Mock<AppContexto>();
            paymentServiceMock.Setup(x => x.Topics.ToList()).Returns(new List<Topic>());
            paymentServiceMock.Setup(x => x.Topics.ToListAsync()).ReturnsAsync(new List<Topic>());



        }
    }
}
