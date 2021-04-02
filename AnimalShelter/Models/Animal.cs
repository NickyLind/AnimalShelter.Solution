using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    [Required]
    public string Type { get; set; }
    [Required]
    [Range(1, 50, ErrorMessage = "Age must be between 0 and 50. If Animal is under a year old round up to 1 year")]
    public int Age  { get; set; }
    [Required]
    public string Gender { get; set; }
    public string Breed { get; set; }
    public string Description { get; set; }
  }
}
