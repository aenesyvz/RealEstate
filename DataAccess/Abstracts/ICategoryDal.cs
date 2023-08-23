using Entities.DTOs.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        Task<List<GetListCategoryDto>> GetAllAsync();
        Task<GetByIdCategoryDto> GetByIdAsync(int id);
        Task AddAsync(AddCategoryDto  addCategoryDto);
        Task UpdateAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteAsync(int id);

    }
}
