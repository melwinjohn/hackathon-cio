using System.Collections.Generic;
using System.Threading.Tasks;
using CIOHackathonDigital.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CIOHackathonDigital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : ControllerBase
    {
        private readonly IPriceInterface _priceHelper;
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet(template: "index")]
        public IActionResult Index() => Ok("Health check");

        // POST api/values
        [HttpPost("getpoints")]
        public async Task<JsonResult> Post([FromBody] string value)
        {
            var result = await _priceHelper.GetPointsForPrice(value);
            return new JsonResult(result);
        }
        
    }
}
