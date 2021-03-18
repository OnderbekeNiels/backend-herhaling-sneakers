using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace backend_herhaling_sneakers.Models
{
    public class Sneaker
    {
        public Guid SneakerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }
        public List<Image> Images { get; set; }
        public Guid BrandId { get; set; }
        public ICollection<SneakerOccasion> SneakerOccasions { get; set; }
        //public List<Image> Images { get; set; }
    }
}
