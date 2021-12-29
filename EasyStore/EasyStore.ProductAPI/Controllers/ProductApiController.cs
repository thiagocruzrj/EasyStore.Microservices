using EasyStore.ProductAPI.Models.Dto;
using EasyStore.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EasyStore.ProductAPI.Controllers
{
    [Route("api/products")]
    public class ProductApiController : ControllerBase
    {
        protected ResponseDto _response;
        private IProductRepository _repository;

        public ProductApiController(IProductRepository repository)
        {
            _repository = repository;
            _response = new ResponseDto();
        }
    }
}