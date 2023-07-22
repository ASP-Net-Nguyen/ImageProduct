﻿namespace ImageProduct.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public List<ProductImage> Images { get; set; }
    }
}
