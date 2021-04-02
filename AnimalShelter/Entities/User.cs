namespace AnimalShelter.Entities
{
  public class User
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Token { get; set; }
  }
}
// The user entity class represents the data for a user in the application. Entity classes are used to pass data between different parts of the application (e.g. between services and controllers) and can be used to return http response data from controller action methods. If multiple types of entities or other custom data is required to be returned from a controller method then a custom model class should be created in the Models folder for the response.