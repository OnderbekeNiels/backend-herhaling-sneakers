using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace backend_herhaling_sneakers.Models
{
    public class Occasion
    {
        public Guid OccasionId { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Sneaker> Sneakers { get; set; }
    }
}
