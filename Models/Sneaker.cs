using System;

namespace backend_herhaling_sneakers.Models
{
    public class Sneaker
    {
        public Guid SneakerId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public Guid BrandId { get; set; }
        public List<Occasion> Occasions { get; set; }
        public List<Image> Images { get; set; }
    }
}
