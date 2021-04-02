using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
      :base(options)
      {
      }
    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Ted", Type = "Cat", Age = 9, Gender = "Female", Breed = "Chocoloate Lab", Description = "Spayed, needs a loving home with older childred/no children"},
          new Animal { AnimalId = 2, Name = "Bradley", Type = "Dog", Age = 2, Gender = "Male", Breed = "Pug", Description = "Neutered, spunky and likes a lot of attention"},
          new Animal { AnimalId = 3, Name = "Ghost", Type = "Dog", Age = 3, Gender = "Male", Breed = "Husky", Description = "Neutered, needs a LOT of exercise"},
          new Animal { AnimalId = 4, Name = "Sparky", Type = "Dog", Age = 1, Gender = "Male", Breed = "Australian Shepherd", Description = "BNeutered, needs to be given tasks for feel important"},
          new Animal { AnimalId = 5, Name = "Molly", Type = "Cat", Age = 9, Gender = "Female", Breed = "Persian", Description = "Spayed, Very shy. Better suited to a home with no/older children"},
          new Animal { AnimalId = 6, Name = "Jose", Type = "Cat", Age = 1, Gender = "Male", Breed = "Tabby(Orange)", Description = "Neutered, very active loves to play"},
          new Animal { AnimalId = 7, Name = "Thor", Type = "Dog", Age = 3, Gender = "Male", Breed = "Great Dane", Description = "Neutered, dumb sweetheart. Needs a lot of room to move around"},
          new Animal { AnimalId = 8, Name = "Charlie", Type = "Dog", Age = 2, Gender = "Female", Breed = "Chocoloate Lab", Description = "Spayed, loves playing fetch and being active"},
          new Animal { AnimalId = 9, Name = "Chloe", Type = "Cat", Age = 2, Gender = "Female", Breed = "Calico", Description = "Spayed, waiting for owner pickup"},
          new Animal { AnimalId = 10, Name = "Rocket", Type = "Dog", Age = 9, Gender = "Male", Breed = "English Bulldog", Description = "Neutered, will need surgery on knees and potentially nose"},
          new Animal { AnimalId = 11, Name = "Tina Turner", Type = "Cat", Age = 4, Gender = "Female", Breed = "Persian", Description = "Spayed, loves sleeping doesn't mind children"}          
        );
    }
  }
}