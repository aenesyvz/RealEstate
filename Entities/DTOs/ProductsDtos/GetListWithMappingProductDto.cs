namespace Entities.DTOs.ProductsDtos
{
    public class GetListWithMappingProductDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string Address { get; set; }
        public string CategoryName { get; set; }
    }
}
