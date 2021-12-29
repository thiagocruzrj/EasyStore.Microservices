using EasyStore.ProductAPI.Models.Dto;
using EasyStore.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<ProductDto> productDtos = await _repository.GetProducts();
                _response.Result = productDtos;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }

            return _response;
        }

    }
}