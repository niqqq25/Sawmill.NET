using Lenta.Shared.Types;

namespace Lenta.Shared.Models.Resource
{
    public class ResourceDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; }
        public Units QuantityType { get; set; }
    }
}
