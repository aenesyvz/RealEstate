using DataAccess.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductDal _productDal;
        public ProductsController(IProductDal productDal)
        {
                _productDal = productDal;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var value = await _productDal.GetAll();
            return Ok(value);
        }

        [HttpGet("GetAllMapping")]
        public async Task<IActionResult> GetAllMapping()
        {
            var values = await _productDal.GetAllWithMapping();
            return Ok(values);
        }
    }
}
