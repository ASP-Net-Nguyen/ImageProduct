using static System.Formats.Asn1.AsnWriter;

namespace ImageProduct.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }

    }
}
