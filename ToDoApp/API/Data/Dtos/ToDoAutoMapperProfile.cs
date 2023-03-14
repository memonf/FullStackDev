using API.Data.Models;
using AutoMapper;

namespace API.Data.Dtos
{
    public class ToDoAutoMapperProfile : Profile
    {
        public ToDoAutoMapperProfile()
        {
            CreateMap<List, ListDto>().ReverseMap();
        }
    }
}