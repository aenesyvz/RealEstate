using Entities.DTOs.WhoWeAreDetailDtos;

namespace DataAccess.Abstracts
{
    public interface IWhoWeAreDetailDal
    {
        Task<List<GetListWhoWeAreDescription>> GetAllAsync();
        Task<GetByIdWhoWeAreDescription> GetById(int id);
        Task AddAsync(AddWhoWeAreDetailDto addWhoWeAreDetailDto);
        Task UpdateAsync(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto);
        Task DeleteAsync(int id);
    }
}
