using ThePetShop.Data;
using ThePetShop.Models;

namespace ThePetShop.Repositories
{
    public interface IPetRepository
    {
        PetContext GetAnimal();
        public void InsertAnimal(string name, int age, string description, string picturePath, int categoryID);
        void UpdateAnimal(int id, Animal animal, int CategoryID);
        void DeleteAnimal(int id);
        List<Animal> GetByCategory(string category);
        List<Animal> GetTopAnimals();
        public Animal AddComment(int animalId, string comment);
        public Animal ShowAnimalById(int animalId);


    }
}
