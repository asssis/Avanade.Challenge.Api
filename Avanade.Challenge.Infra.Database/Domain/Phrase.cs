using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avanade.Challenge.Api.Infra.Database.Domain
{
    public class Phrase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite a frase!"), Column(Order = 1)]
        [MinLength(5, ErrorMessage = "O tamanho mínimo da frase são 5 caracteres.")]
        [StringLength(200, ErrorMessage = "O tamanho máximo são 200 caracteres.")]
        public string Expression { get; set; }


        [ForeignKey("Topic")]
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
