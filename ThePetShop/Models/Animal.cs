using System.ComponentModel.DataAnnotations;

namespace ThePetShop.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        
        [Required(ErrorMessage = "Please enter a name.")]
        public string? Name { get; set; }
        
        [Required(ErrorMessage = "Please enter an age"), Range(0, 50)]        
        public int? Age { get; set; }

        [Required(ErrorMessage = "Please enter a Picture Path")]
        public string? PicturePath { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]       
        public string? Description { get; set; }
        public int CategoryID { get; set; }
        public Category? Category { get; set; }
        public ICollection<Comment>? Comments { get; set; }
    }
}
