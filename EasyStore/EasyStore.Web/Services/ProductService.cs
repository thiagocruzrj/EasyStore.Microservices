using EasyStore.Web.Models;
using EasyStore.Web.Services.IServices;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EasyStore.Web.Services
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ProductService(IHttpClientFactory httpClient) : base(httpClient)
        {
            _clientFactory = httpClient;
        }

        public async Task<T> CreateProductByIdAsync<T>(ProductDto productDto)
        {
            return await SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = productDto,
                Url = SD.ProductAPIBase + "/api/products",
                AccessToken = ""
            });
        }

        public async Task<T> DeleteProductByIdAsync<T>(int id)
        {
            return await SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Data = id,
                Url = SD.ProductAPIBase + "/api/products",
                AccessToken = ""
            });
        }

        public Task<T> GetAllProductsAsync<T>()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetProductByIdAsync<T>(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateProductByIdAsync<T>(ProductDto productDto)
        {
            throw new NotImplementedException();
        }
    }
}
