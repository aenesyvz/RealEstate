using DataAccess.Abstracts;
using Dapper;
using Entities.DTOs.ProductsDtos;

namespace DataAccess.Concretes
{
    public class DfProductDal : IProductDal
    {
        private readonly Context _context;
        public DfProductDal(Context context)
        {
            _context = context;
        }

        public async Task<List<GetListProductDto>> GetAll()
        {
            string query = "Select * From Products";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<GetListProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<GetListWithMappingProductDto>> GetAllWithMapping()
        {
            string query = "Select p.Id,p.Title, p.Price,p.CityId,p.DistrictId,c.Name as CategoryName From Products as p" +
                " inner join Categories As c on p.CategoryId = c.Id";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<GetListWithMappingProductDto>(query);
                return values.ToList();
            }
        }
    }
}
