using EasyStore.Web.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EasyStore.Web.Services.IServices
{
    public class BaseService : IBaseService
    {
        public ResponseDto ResponseModel { get ; set; }
        public IHttpClientFactory HttpClient { get; set; }

        public BaseService(IHttpClientFactory httpClient)
        {
            ResponseModel = new ResponseDto();
            HttpClient = httpClient;
        }

        public Task<T> SendAsync<T>(ApiRequest apiRequest)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
