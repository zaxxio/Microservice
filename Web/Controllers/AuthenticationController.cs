using Microsoft.AspNetCore.Mvc;

namespace Web.Controller;

[ApiController]
[Route("")]
public class AuthenticationController : ControllerBase
{
    [Route("/")]
    public string sayHello()
    {
        Thread.Sleep(3000);
        return "Hello World";
    }
}