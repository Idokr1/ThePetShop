using System.ComponentModel.DataAnnotations;

namespace ThePetShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        public string? CategoryName { get; set; }
        public virtual IEnumerable<Animal>? Animals { get; set; }
    }
}
