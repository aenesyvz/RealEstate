using Entities.DTOs.ProductsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public  interface IProductDal
    {
        Task<List<GetListProductDto>> GetAll();
        Task<List<GetListWithMappingProductDto>> GetAllWithMapping();
    }
}
