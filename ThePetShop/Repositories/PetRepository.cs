using Microsoft.EntityFrameworkCore;
using ThePetShop.Data;
using ThePetShop.Models;

namespace ThePetShop.Repositories
{
    public class PetRepository : IPetRepository
    {
        private PetContext _context;
        public PetRepository(PetContext context)
        {
            _context = context;
        }

        public PetContext GetAnimal()
        {
            return _context;
        }

        public void InsertAnimal(string name, int age, string description, string picturePath, int categoryID)
        {
            _context.Animals!.Add(new Animal { Name = name, Age = age, Description = description, PicturePath = picturePath, CategoryID = categoryID });                       
            _context.SaveChanges();
        }


        public void UpdateAnimal(int id, Animal animal, int categoryID)
        {
            var animalInDb = _context.Animals!.Single(m => m.AnimalId == id);
            if (categoryID != animalInDb.CategoryID)
                animalInDb!.CategoryID = categoryID;
            _context.Animals!.Update(animalInDb!);
            animalInDb!.Name = animal.Name;
            animalInDb.Age = animal.Age;
            animalInDb.PicturePath = animal.PicturePath;
            animalInDb.Description = animal.Description;
            _context.SaveChanges();
        }

        public void DeleteAnimal(int id)
        {
            var animal = _context.Animals!.SingleOrDefault(m => m.AnimalId == id);
            _context.Remove(animal!);
            _context.SaveChanges();
        }

        public List<Animal> GetByCategory(string category)
        {
            if (category == null)
            {
                return _context.Animals!.ToList();
            }
            else
            {
                return _context.Animals!.Include(c => c.Category).ThenInclude(c => c!.Animals!).ThenInclude(c => c.Comments!).Where(c => c.Category!.CategoryName == category).ToList();
            }
        }

        public List<Animal> GetTopAnimals()
        {
            return _context.Animals!.Include(c => c.Comments).OrderByDescending(c => c.Comments!.Count).Take(2).ToList();
        }

        public Animal AddComment(int animalId, string comment)
        {
            _context.Animals!.Include(c => c.Category!).ThenInclude(c => c.Animals!).ThenInclude(c => c.Comments!).Single(c => c.AnimalId! == animalId).Comments!.Add(new Comment { CommentText = comment });
            _context.SaveChanges();
            return _context.Animals!.Include(c => c.Comments!).Single(c => c.AnimalId! == animalId);
        }

        public Animal ShowAnimalById(int animalId)
        {
            var categories = _context.Animals!.Include(c => c.Category).ThenInclude(c => c!.Animals!).ThenInclude(c => c.Comments!);
            var animal = categories!.Single(m => m.AnimalId == animalId);
            return animal;
        }
    }
}
