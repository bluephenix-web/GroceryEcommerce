using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grocery.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public decimal Price { get; set; }

        public int quantity { get; set; }

        public string status { get; set; }

    }
}
