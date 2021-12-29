using EasyStore.Web.Models;
using System;
using System.Threading.Tasks;

namespace EasyStore.Web.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        ResponseDto ResponseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}