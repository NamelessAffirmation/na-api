using Core.Services.Interfaces;
using Data.Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


[ApiController]
[Route("users")]
[Produces("application/json")]
public class UserController(IUserService userService) : ControllerBase
{
    private readonly IUserService _userService = userService;
    
    [HttpGet]
    [Route("")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<IQueryable<IUser>> GetUser()
    {
        var result = _userService.GetUserById(12);
 
        return Ok(result);
    }
}