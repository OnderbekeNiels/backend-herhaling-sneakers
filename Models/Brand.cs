using System;
using System.ComponentModel.DataAnnotations;

namespace backend_herhaling_sneakers.Models
{
    public class Brand
    {
        public Guid BrandId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
