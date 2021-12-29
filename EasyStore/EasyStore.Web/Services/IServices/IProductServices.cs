using System.Threading.Tasks;

namespace EasyStore.Web.Services.IServices
{
    public interface IProductServices
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductByIdAsync<T>(int Id);
        Task<T> CreateProductByIdAsync<T>();
        Task<T> UpdateProductByIdAsync<T>();
        Task<T> DeleteProductByIdAsync<T>(int id);
    }
}