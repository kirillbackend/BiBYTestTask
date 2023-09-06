using System.Text;
using TestTask.Services.Interface;

namespace TestTask.Services
{
    public class PalindromeService : ICheckingPalindrome
    {
        /// <summary>
        /// Проверяет строку на палиндром
        /// </summary>
        /// <param name="words"> строка </param>
        /// <returns> булево зданчение полиндром строка или нет </returns>
        public async Task<bool> IsPalindromeAsync(string words)
        {
            return await Task.Run(()=>
            {
                string reverseWords = ReverseWords(words);
                return words == reverseWords;
            });
        }

        /// <summary>
        /// Алгоритм разворота строки
        /// </summary>
        /// <param name="words"> строка </param>
        /// <returns> развернутая строка </returns>
        private string ReverseWords(string words)
        {
            var builder = new StringBuilder();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                builder.Append(words[i]);
            }
            return builder.ToString();
        }
    }
}
