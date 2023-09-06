using Microsoft.AspNetCore.Mvc;
using TestTask.Services.Interface;

namespace TestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalindromeController : ControllerBase
    {
        /// <summary>
        /// Проверяет является ли строка палиндромом
        /// </summary>
        /// <param name="words"> строка </param>
        /// <param name="palindromeService"> служба для проверки на палиндром </param>
        /// <returns> булево значение в зависимости от того палиндром это или нет </returns>
        [HttpGet,Route("Palindrome")]
        public async Task<bool> IsPalindromeAsync([FromQuery] string words, ICheckingPalindrome palindromeService)
        {
            return await palindromeService.IsPalindromeAsync(words);
        }
    }
}
