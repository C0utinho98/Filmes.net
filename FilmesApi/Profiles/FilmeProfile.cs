
using AutoMapper;
using FilmesApi.Dto;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<UpdateFilmeDto, Filme>();
            CreateMap<Filme, UpdateFilmeDto>();
        }
    }
}