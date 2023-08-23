using DataAccess.Abstracts;
using Entities.DTOs.WhoWeAreDetailDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailsController : ControllerBase
    {
        private readonly IWhoWeAreDetailDal _whoWeAreDetailDal;

        public WhoWeAreDetailsController(IWhoWeAreDetailDal whoWeAreDetailDal)
        {
            _whoWeAreDetailDal = whoWeAreDetailDal;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var values = await _whoWeAreDetailDal.GetAllAsync();
            return Ok(values);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _whoWeAreDetailDal.GetById(id);
            return Ok(value);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(AddWhoWeAreDetailDto addWhoWeAreDetailDto)
        {
            await _whoWeAreDetailDal.AddAsync(addWhoWeAreDetailDto);
            return Ok("Biz Kimiz Eklendi");

        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto)
        {
            await _whoWeAreDetailDal.UpdateAsync(updateWhoWeAreDetailDto);
            return Ok("Biz Kimiz Güncellendi");
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _whoWeAreDetailDal.DeleteAsync(id);
            return Ok("Biz Kimiz Silindi");
        }
    }
}
