using Dapper;
using DataAccess.Abstracts;
using Entities.DTOs.WhoWeAreDetailDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class DfWhoWeAreDetailDal : IWhoWeAreDetailDal
    {
        private readonly Context _context;
        public DfWhoWeAreDetailDal(Context context)
        {
            _context = context;
        }
        public async Task AddAsync(AddWhoWeAreDetailDto addWhoWeAreDetailDto)
        {
            string query = "Insert Into WhoWeAreDetail (Title,Subtitle,Description1,Description2) values (@title,@subtitle,@description1,@description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", addWhoWeAreDetailDto.Title);
            parameters.Add("@subtitle", addWhoWeAreDetailDto.Subtitle);
            parameters.Add("@description1", addWhoWeAreDetailDto.Description1);
            parameters.Add("@description2", addWhoWeAreDetailDto.Description2);

            using (var connection = _context.CreateConnection()) 
            { 
                await connection.ExecuteAsync(query, parameters);
            }
        }


        public async Task DeleteAsync(int id)
        {
            string query = "Delete From WhoWeAreDetail Where Id = @id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);

            using(var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<GetListWhoWeAreDescription>> GetAllAsync()
        {
            string query = "Select * From WhoWeAreDetail";

            using(var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<GetListWhoWeAreDescription>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdWhoWeAreDescription> GetById(int id)
        {
            string query = "Select * From WhoWeAreDetail Where Id = @id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);

            using(var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdWhoWeAreDescription>(query, parameters);
                return values;
            }
        }

        public async Task UpdateAsync(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto)
        {
            string query = "Update WhoWeAreDetail Set Title=@title, Subtitle=@subtitle, Description1=@description1, Description2=@description2 Where Id=@id";
            
            var parameters = new DynamicParameters();
            parameters.Add("@id", updateWhoWeAreDetailDto.Id);
            parameters.Add("@title", updateWhoWeAreDetailDto.Title);
            parameters.Add("@subtitle", updateWhoWeAreDetailDto.Subtitle);
            parameters.Add("@description1", updateWhoWeAreDetailDto.Description1);
            parameters.Add("@description2", updateWhoWeAreDetailDto.Description2);

            using(var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
