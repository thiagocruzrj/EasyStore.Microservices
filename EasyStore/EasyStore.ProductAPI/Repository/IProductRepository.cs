using EasyStore.ProductAPI.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyStore.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int productId);
        Task<ProductDto> UpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productId);
    }
}