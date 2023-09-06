using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestTask.Services.Interface;

namespace TestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SumModuloController : ControllerBase
    {
        /// <summary>
        /// Получает сумму сложения каждого второго нечетного числа из массива чисел
        /// </summary>
        /// <param name="numbers"> массив чисел </param>
        /// <param name="sumService"> сервис для сложения чисел </param>
        /// <returns> сумма чисел </returns>
        [HttpGet, Route("Sum")]
        public async Task<int> GetSumAsync([FromQuery] int[] numbers, ISum sumService)
        {
            return await sumService.GetSumAsync(numbers);
        }
    }
}
