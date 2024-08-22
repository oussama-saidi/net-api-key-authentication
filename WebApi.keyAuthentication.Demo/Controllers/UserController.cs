using Microsoft.AspNetCore.Mvc;
using WebApi.keyAuthentication.Demo.Authentication;

namespace WebApi.keyAuthentication.Demo.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    public UserController()
    {
    }

    [ApiKey]
    [HttpGet(Name = "GetAllUsers")]
    public List<string> GetAll()
    {
        return new List<string> { "Stefan" };
    }
}