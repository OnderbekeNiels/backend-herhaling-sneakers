using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace backend_herhaling_sneakers.Models
{
    public class Image
    {

        public Guid ImageId { get; set; }
        [Required]
        public string Name { get; set; }
        // public Blob ImageFile { get; set; }

        public Guid SneakerId { get; set; }
    }
}
