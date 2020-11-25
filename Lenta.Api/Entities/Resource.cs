using Lenta.Shared.Types;
using System;
using System.ComponentModel.DataAnnotations;

namespace Lenta.Api.Entities
{
    public class Resource : Entity
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [Range(0, int.MaxValue)]
        public float Quantity { get; set; }
        [Required]
        public Units QuantityType { get; set; }
    }
}
