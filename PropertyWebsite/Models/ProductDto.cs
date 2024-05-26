using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PropertyWebsite.Models
{
    public class ProductDto
    {
        [Required, MaxLength(100)]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; } = "";
        [Required, MaxLength(100)]
        public string Address { get; set; } = "";
        [Required, MaxLength(100)]
        public string Category { get; set; } = "";
        [Precision(16, 2)]

        [Required]
        public decimal Price { get; set; }
        public IFormFile? ImageFile { get; set; }
    }
}
