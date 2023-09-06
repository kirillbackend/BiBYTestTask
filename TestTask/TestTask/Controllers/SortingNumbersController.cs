using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestTask.Services.Interface;

namespace TestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SortingNumbersController : ControllerBase
    {
        /// <summary>
        /// Сортирует числа
        /// </summary>
        /// <param name="numbers"> числа для сортировки </param>
        /// <param name="sortService"> служба для сортировки </param>
        /// <returns> отсортированные числа </returns>
        [HttpGet, Route("SotrNumbers")]
        public async Task<int[]> GetNumbers([FromQuery] int[] numbers, ISort sortService)
        {
            return await sortService.GerSort(numbers);
        }
    }
}
