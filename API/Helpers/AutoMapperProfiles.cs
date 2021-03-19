using API.DTOs;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
      public class AutoMapperProfiles : Profile
      {
            public AutoMapperProfiles()
            {
                  CreateMap<Product, ProductDto>();
            }
      }
}