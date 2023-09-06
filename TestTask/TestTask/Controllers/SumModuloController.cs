using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestTask.Services.Interface;

namespace TestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SumModuloController : ControllerBase
    {
        [HttpGet, Route("Sum")]
        public async Task<int> GetSumAsync([FromQuery] int[] numbers, ISum sumService)
        {
            return await sumService.GetSumAsync(numbers);
        }
    }
}
