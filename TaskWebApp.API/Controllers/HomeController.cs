using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace TaskWebApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        public async Task<IActionResult> GetContentAsync()
        {

            var myTask = new HttpClient().GetStringAsync("http://www.google.com");

            var data = await myTask;

            return Ok(data);

        }


    }
}
