﻿namespace TakeAwayNight.Catalog.Dtos.ProductDtos
{
    public class CreateProductDto
    {
      
        public string ProducName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
