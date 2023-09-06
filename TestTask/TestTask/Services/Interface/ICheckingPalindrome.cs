namespace TestTask.Services.Interface
{
    public interface ICheckingPalindrome
    {
        /// <summary>
        /// Интерфейс для проверки на полиндром
        /// </summary>
        /// <param name="words"> строка для проверки </param>
        /// <returns> булево значение </returns>
        Task<bool> IsPalindromeAsync(string words);
    }
}