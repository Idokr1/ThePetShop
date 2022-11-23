using System.ComponentModel.DataAnnotations;

namespace ThePetShop.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        [Required]
        public string? CommentText { get; set; }
        public int AnimalId { get; set; }
        public Animal? Animal { get; set; }
    }
}
