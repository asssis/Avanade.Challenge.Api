using System.ComponentModel.DataAnnotations;

namespace Avanade.Challenge.Api.Infra.Database.Domain
{ 
    public class Topic
    {
        public Topic(string descricao)
        {
            Descricao = descricao;
        }
        public Topic() 
        { }

        [Key]
        public int Id { get; set; }
         
        public string Descricao { get; set; }
    }
}
