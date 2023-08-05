using DataAccess.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryDal _categoryDal;

        public CategoriesController(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var value = await _categoryDal.GetAllAsync();
            return Ok(value);
        }
    }
}
