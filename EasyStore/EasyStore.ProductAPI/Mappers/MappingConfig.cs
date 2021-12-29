using AutoMapper;
using EasyStore.ProductAPI.Models;
using EasyStore.ProductAPI.Models.Dto;

namespace EasyStore.ProductAPI.Mappers
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductDto, Product>();
                c.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;
        }
    }
}