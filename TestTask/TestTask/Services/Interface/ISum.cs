namespace TestTask.Services.Interface
{
    public interface ISum
    {
        /// <summary>
        /// Интерфейс для сложения каждого второго нечетного числа из массива чисел
        /// </summary>
        /// <param name="numbers"> массив чисел </param>
        /// <returns> Сумма чисел </returns>
        Task<int> GetSumAsync(int[] numbers);
    }
}