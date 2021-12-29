using EasyStore.Web.Models;
using System.Threading.Tasks;

namespace EasyStore.Web.Services.IServices
{
    public interface IProductService : IBaseService
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductByIdAsync<T>(int Id);
        Task<T> CreateProductByIdAsync<T>(ProductDto productDto);
        Task<T> UpdateProductByIdAsync<T>(ProductDto productDto);
        Task<T> DeleteProductByIdAsync<T>(int id);
    }
}