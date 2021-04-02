using System.Collections.Generic;
using System.Linq;
using AnimalShelter.Entities;

namespace WebApi.Helpers
{
  public static class ExtensionMethods
  {
    public static IEnumerable<User> WithoutPasswords(this IEnumerable<User> users)
    {
      return users.Select(user => user.WithoutPassword());
    }

    public static User WithoutPassword(this User user)
    {
      user.Password = null;
      return user;
    }
  }
}
// Extension methods are used to add convenience methods and extra functionality to existing types in C#.

// The extension methods class adds a couple of simple convenience methods for removing passwords from User instances and IEnumerable<User> collections. These methods are called by the Authenticate and GetAll methods in the UserService to ensure the user objects returned don't include passwords.