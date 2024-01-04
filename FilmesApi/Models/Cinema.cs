using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Controllers
{
    public class Cinema
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }

    }
}