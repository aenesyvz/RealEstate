using DataAccess.Abstracts;
using Entities.DTOs.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        private readonly Context _context;
        public CategoryDal(Context context)
        {
            _context = context;
        }

        public async Task<List<ListCategoryDto>> GetAllAsync()
        {
            string query = "Select * From Categories";
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryAsync<ListCategoryDto>(query);
                return value.ToList();
            }
        }
    }
}
