using AuthApp.Data;
using AuthApp.Models.DTO;
using AutoMapper;

namespace AuthApp.MappingProfiles
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<BookDto, Book>().ReverseMap();
            CreateMap<BookFullDto, Book>().ReverseMap();
        }
    }
}
