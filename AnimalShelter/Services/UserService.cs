using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using AnimalShelter.Entities;
using AnimalShelter.Helpers;

namespace AnimalShelter.Services
{
  public interface IUserService
  {
    User Authenticate(string username, string password);
    IEnumerable<User> GetAll();
  }

  public class UserService : IUserService
  {
    private List<User> _users = new List<User>
    {
      new User { Id = 1, FirstName = "Test", LastName = "User", Username = "test", Password = "test" }
    };

    private readonly AppSettings _appSettings;

    public UserService(IOptions<AppSettings> appSettings)
    {
      _appSettings = appSettings.Value;
    }

    public User Authenticate(string username, string password)
    {
      var user = _users.SingleOrDefault(user => user.Username == username && user.Password == password);
      // return null if user not found
      if (user == null)
      {
        return null;
      }

      // authentication successful so generate jwt token
      var tokenHandler = new JwtSecurityTokenHandler();
      var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
      var tokenDescriptor = new SecurityTokenDescriptor
      {
        Subject = new ClaimsIdentity(new Claim[]
        {
          new Claim(ClaimTypes.Name, user.Id.ToString())
        }),
        Expires = DateTime.UtcNow.AddDays(7),
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
      };
      var token = tokenHandler.CreateToken(tokenDescriptor);
      user.Token = tokenHandler.WriteToken(token);

      return user.WithoutPassword();
    }

    public IEnumerable<User> GetAll()
    {
      return _users.WithoutPasswords();
    }
  }
}


// The user service contains a method for authenticating user credentials and returning a JWT token, and a method for getting all users in the application.

// I hardcoded the array of users in the example to keep it focused on JWT authentication, in a production application it is recommended to store user records in a database with hashed passwords.

// The top of the file contains an interface that defines the user service, below that is the concrete user service class that implements the interface.

// On successful authentication the Authenticate method generates a JWT (JSON Web Token) using the JwtSecurityTokenHandler class which generates a token that is digitally signed using a secret key stored in appsettings.json. The JWT token is returned to the client application which must include it in the HTTP Authorization header of subsequent requests to secure routes.