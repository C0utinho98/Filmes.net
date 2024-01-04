using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Dto;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CinemaController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _mapper;

        public CinemaController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult AdicionarFilme([FromBody] CreateCinemaDto cinemaDto)
        {
            Cinema cinema = _mapper.Map<Cinema>(cinemaDto);
            _context.Cinemas.Add(cinema);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaCinemaPorId), new { id = cinema.id }, cinema);
        }


        [HttpGet]
        public IEnumerable<ReadCinemaDto> RecuperarCinemas()
        {
            return _mapper.Map<List<ReadCinemaDto>>(_context.Cinemas.toList());
        }


        [HttpGet("{id}")]
        public IActionResult RecuperaCinemaPorId(int id)
        {
            Cinema cinema = _context.Cinemas.FirstOrDefault(filme => filme.Id == id);

            if (cinema == null)
            {
                return NotFound();
            }
            ReadCinemaDto cinemaDto = _mapper.Map<ReadCinemaDto>(cinema);
            return Ok(cinemaDto);
        }
    }
}