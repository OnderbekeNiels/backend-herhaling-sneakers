using System;

namespace backend_herhaling_sneakers.Models
{
    public class Image
    {
        public Guid ImageId { get; set; }
        public string Name { get; set; }
        public Blob Image { get; set; }
    }
}
