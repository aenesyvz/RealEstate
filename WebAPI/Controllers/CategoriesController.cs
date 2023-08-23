using DataAccess.Abstracts;
using Entities.DTOs.CategoryDtos;
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

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _categoryDal.GetByIdAsync(id);
            return value != null ? Ok(value) : Ok("Kategori getirilemedi");
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddCategoryDto addCategoryDto)
        {
             await _categoryDal.AddAsync(addCategoryDto);
            return Ok("Kategori başarılı bir şekilde eklendi!");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryDal.DeleteAsync(id);
            return Ok("Kategori silindi");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCategoryDto updateCategoryDto)
        {
            await _categoryDal.UpdateAsync(updateCategoryDto);
            return Ok("Kategori güncellendi");
        }
    }
}
