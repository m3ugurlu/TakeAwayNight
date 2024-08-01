namespace TakeAwayNight.Catalog.Dtos.ProductDtos
{
    public class UpdateProductDto
    {

        public string ProducId { get; set; }
        public string ProducName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
