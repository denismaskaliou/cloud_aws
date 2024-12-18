using AutoMapper;
using Domain.Entities;

namespace WebAPI_WebApp.Models;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductDto>().ReverseMap();
    }
}