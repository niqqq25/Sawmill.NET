using Lenta.Shared.Types;

namespace Lenta.Shared.Models.Product
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public decimal UnitPrice { get; set; }
        public ProductType Type { get; set; }
    }
}
