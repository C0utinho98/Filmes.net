

using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Dto
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }

    }
}