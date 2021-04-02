using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using AnimalShelter.Services;
using AnimalShelter.Models;
using System.Linq;

namespace AnimalShelter.Controllers
{
  [Authorize]
  [ApiController]
  [Route("[controller]")]
  public class UsersController : ControllerBase
  {
    private IUserService _userService;

    public UsersController(IUserService userService)
    {
      _userService = userService;
    }

    [AllowAnonymous]
    [HttpPost("authenticate")]
    public IActionResult Authenticate([FromBody]AuthenticateModel model)
    {
      var user = _userService.Authenticate(model.Username, model.Password);

      if (user == null)
      {
        return BadRequest(new { message = "Username or password is incorrect" });
      }
      return Ok(user);
    }
    [HttpGet]
    public IActionResult GetAll()
    {
      var users = _userService.GetAll();
      return Ok(users);
    }
  }
}
// The ASP.NET Core users controller defines and handles all routes / endpoints for the api that relate to users, this includes authentication and standard CRUD operations. Within each route the controller calls the user service to perform the action required, this enables the controller to stay 'lean' and completely separated from the business logic and data access code.

// The controller actions are secured with JWT using the [Authorize] attribute, with the exception of the Authenticate method which allows public access by overriding the [Authorize] attribute on the controller with [AllowAnonymous] attribute on the action method. I chose this approach so any new action methods added to the controller will be secure by default unless explicitly made public.