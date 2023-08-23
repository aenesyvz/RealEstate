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
    public class DfCategoryDal : ICategoryDal
    {
        private readonly Context _context;
        public DfCategoryDal(Context context)
        {
            _context = context;
        }

        public async Task AddAsync(AddCategoryDto addCategoryDto)
        {
            string query = "insert into Categories (Name,Status) values (@name,@status)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", addCategoryDto.Name);
            parameters.Add("@status", addCategoryDto.Status);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteAsync(int id)
        {
            string query = "Delete From Categories Where Id=@Id";
            var parameters = new DynamicParameters();
            parameters.Add("Id", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<GetListCategoryDto>> GetAllAsync()
        {
            string query = "Select * From Categories";

            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryAsync<GetListCategoryDto>(query);
                return value.ToList();
            }
        }

        public async Task<GetByIdCategoryDto> GetByIdAsync(int id)
        {
            var query = "Select * From Categories Where Id=@Id";
            var parameters = new DynamicParameters();
            parameters.Add("Id", id);

            using(var connection = _context.CreateConnection())
            {
                var value = await connection.QueryAsync<GetByIdCategoryDto>(query,parameters);
                return value.FirstOrDefault();
            }
        }

        public async Task UpdateAsync(UpdateCategoryDto updateCategoryDto)
        {
            string query = "Update Categories Set Name=@Name,Status=@Status Where Id=@Id";
            var parameters = new DynamicParameters();
            parameters.Add("Id", updateCategoryDto.Id);
            parameters.Add("Name", updateCategoryDto.Name);
            parameters.Add("Status", updateCategoryDto.Status);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
