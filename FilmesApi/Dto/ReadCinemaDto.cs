using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Dto
{
    public class ReadCinemaDto
    {
        public int id { get; set; }
        public string Nome { get; set; }
    }
}