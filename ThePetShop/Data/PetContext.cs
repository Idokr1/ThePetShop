using Microsoft.EntityFrameworkCore;
using ThePetShop.Models;

namespace ThePetShop.Data
{
    public class PetContext : DbContext
    {
        public PetContext(DbContextOptions<PetContext> options) : base(options) { }

        public DbSet<Animal>? Animals { get; set; }
        public virtual DbSet<Category>? Categories { get; set; }
        public virtual DbSet<Comment>? Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().HasData(
                new { AnimalId = 1, Name = "Parrot", Age = 6, PicturePath = @"/Pictures/Parrot.jpg", Description = "Parrots, also known as psittacines, are birds of the roughly 398 species in 92 genera comprising the order Psittaciformes, found mostly in tropical and subtropical regions.", CategoryID = 1 },
                new { AnimalId = 2, Name = "Kingfisher", Age = 4, PicturePath = "/Pictures/Kingfisher.jpg", Description = "Kingfishers or Alcedinidae are a family of small to medium-sized, brightly colored birds in the order Coraciiformes. They have a cosmopolitan distribution, with most species found in the tropical regions of Africa, Asia, and Oceania but also can be seen in Europe.", CategoryID = 1 },
                new { AnimalId = 3, Name = "Columbidae", Age = 5, PicturePath = "/Pictures/Columbidae.jpg", Description = "Columbidae is a bird family consisting of doves and pigeons. It is the only family in the order Columbiformes. These are stout-bodied birds with short necks and short slender bills that in some species feature fleshy ceres. They primarily feed on seeds, fruits, and plants.", CategoryID = 1 },
                new { AnimalId = 4, Name = "Cuckoos", Age = 3, PicturePath = "/Pictures/Cuckoos.jpg", Description = "Cuckoos are birds in the Cuculidae family, the sole taxon in the order Cuculiformes. The cuckoo family includes the common or European cuckoo, roadrunners, koels, malkohas, couas, coucals and anis.", CategoryID = 1 },
                new { AnimalId = 5, Name = "Golden Retriever", Age = 4, PicturePath = "/Pictures/GoldenRetriever.jpg", Description = "The Golden Retriever is a Scottish breed of retriever dog of medium size. It is characterised by a gentle and affectionate nature and a striking golden coat. It is commonly kept as a pet and is among the most frequently registered breeds in several Western countries.", CategoryID = 2 },
                new { AnimalId = 6, Name = "Bulldog", Age = 9, PicturePath = "/Pictures/Bulldog.jpg", Description = "The Bulldog is a British breed of dog of mastiff type. It may also be known as the English Bulldog or British Bulldog. It is of medium size, a muscular, hefty dog with a wrinkled face and a distinctive pushed-in nose.", CategoryID = 2 },
                new { AnimalId = 7, Name = "Poodle", Age = 6, PicturePath = "/Pictures/Poodle.jpg", Description = "The Poodle, called the Pudel in German and the Caniche in French, is a breed of water dog. The breed is divided into four varieties based on size, the Standard Poodle, Medium Poodle, Miniature Poodle and Toy Poodle, although the Medium Poodle variety is not universally recognised.", CategoryID = 2 },
                new { AnimalId = 8, Name = "Chihuahua", Age = 13, PicturePath = "/Pictures/Chihuahua.jpg", Description = "The Chihuahua or Spanish: Chihuahueño is a Mexican breed of toy dog. It is named for the Mexican state of Chihuahua and is among the smallest of all dog breeds. It is usually kept as a companion animal or for showing.", CategoryID = 2 },
                new { AnimalId = 9, Name = "British Shorthair", Age = 3, PicturePath = "/Pictures/BritishShorthair.jpg", Description = "The British Shorthair is the pedigreed version of the traditional British domestic cat, with a distinctively stocky body, dense coat, and broad face. The most familiar colour variant is the 'British Blue', with a solid grey-blue coat, orange eyes, and a medium-sized tail.", CategoryID = 3 },
                new { AnimalId = 10, Name = "Maine Coon", Age = 8, PicturePath = "/Pictures/MaineCoon.jpg", Description = "The Maine Coon is a large domesticated cat breed. It is one of the oldest natural breeds in North America. The breed originated in the U.S. state of Maine, where it is the official state cat", CategoryID = 3 },
                new { AnimalId = 11, Name = "Siamese Cat", Age = 2, PicturePath = "/Pictures/SiameseCat.jpg", Description = "The Siamese cat is one of the first distinctly recognized breeds of Asian cat. Derived from the Wichianmat landrace, one of several varieties of cat native to Thailand, the original Siamese became one of the most popular breeds in Europe and North America in the 19th century.", CategoryID = 3 },
                new { AnimalId = 12, Name = "Ragdoll", Age = 4, PicturePath = "/Pictures/Ragdoll.jpg", Description = "The Ragdoll is a breed of cat with a distinct colorpoint coat and blue eyes. Its morphology is large and weighty, and it has a semi-long and silky soft coat. American breeder Ann Baker developed Ragdolls in the 1960s. They are best known for their docile, placid temperament and affectionate nature", CategoryID = 3 }
                );

            modelBuilder.Entity<Category>().HasData(
                new { CategoryId = 1, CategoryName = "Birds" },
                new { CategoryId = 2, CategoryName = "Dogs" },
                new { CategoryId = 3, CategoryName = "Cats" }
                );

            modelBuilder.Entity<Comment>().HasData(
              new { CommentId = 1, AnimalId = 1, CommentText = "Beautiful colors" },
              new { CommentId = 2, AnimalId = 1, CommentText = "The Parrot is just awesome. " },
              new { CommentId = 3, AnimalId = 2, CommentText = "The Kingfisher is the most beautiful bird I've ever seen" },
              new { CommentId = 4, AnimalId = 3, CommentText = "Amazing bird!" },
              new { CommentId = 5, AnimalId = 4, CommentText = "Cuckoos is my favorite :)" },
              new { CommentId = 6, AnimalId = 4, CommentText = "I saw one in my last trip!" },
              new { CommentId = 7, AnimalId = 5, CommentText = "Golden Retrievers are playful" },
              new { CommentId = 8, AnimalId = 5, CommentText = "They are really gentle with children" },
              new { CommentId = 9, AnimalId = 5, CommentText = "They like to be active." },
              new { CommentId = 10, AnimalId = 5, CommentText = "I have one :)" },
              new { CommentId = 11, AnimalId = 6, CommentText = "Easy to train." },
              new { CommentId = 12, AnimalId = 6, CommentText = "Bulldogs are so nice" },
              new { CommentId = 13, AnimalId = 6, CommentText = "The Bulldog is a large dog." },
              new { CommentId = 14, AnimalId = 7, CommentText = "Poodles have nice hair" },
              new { CommentId = 15, AnimalId = 8, CommentText = "The Chihuahuas are so small" },
              new { CommentId = 16, AnimalId = 8, CommentText = "Their barks are funny :)" },
              new { CommentId = 17, AnimalId = 9, CommentText = "A daily brushing is important, especially during seasonal changes." },
              new { CommentId = 18, AnimalId = 9, CommentText = "The British is a fiercely loyal, loving cat and will attach herself to every one of her family members." },
              new { CommentId = 19, AnimalId = 9, CommentText = "British Shorthairs can weigh more than the average cat!" },
              new { CommentId = 20, AnimalId = 9, CommentText = "They are known as one of the oldest cat breeds in the world." },
              new { CommentId = 21, AnimalId = 9, CommentText = "Many people have noted that these cats do not feel fluffy, but instead feel plush." },
              new { CommentId = 22, AnimalId = 10, CommentText = "Some of them are really huge!" },
              new { CommentId = 23, AnimalId = 10, CommentText = "They are known as 'Gentle Giants'" },
              new { CommentId = 24, AnimalId = 11, CommentText = "They are really friendly" },
              new { CommentId = 25, AnimalId = 11, CommentText = "They came from Thailand originally" },
              new { CommentId = 26, AnimalId = 12, CommentText = "Ragdoll cats are known to be gentle, calm and sociable." },
              new { CommentId = 27, AnimalId = 12, CommentText = "I love them :)" },
              new { CommentId = 28, AnimalId = 12, CommentText = "They are really friendly" }
              );
        }
    }
}
