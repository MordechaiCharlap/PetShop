using PetShop.Data.Model;

namespace PetShop.Client.Models
{
    public class AnimalDetailsViewModel
    {
        public Animal Animal { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public AnimalDetailsViewModel(Animal animal, IEnumerable<Comment> comments)
        {
            Animal = animal;
            Comments = comments;
        }
    }
}
