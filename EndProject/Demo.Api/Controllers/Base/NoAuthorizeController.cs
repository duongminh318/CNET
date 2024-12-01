using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Api.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    /*  public class NoAuthorizeController : ControllerBase*/
    public abstract class NoAuthorizeController : ControllerBase
    {

    }
}
