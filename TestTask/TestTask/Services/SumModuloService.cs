using TestTask.Services.Interface;

namespace TestTask.Services
{
    public class SumModuloService : ISum
    {
        /// <summary>
        /// Сервия для получения суммы сложения каждого второго нечетного числа из массива чисел
        /// </summary>
        /// <param name="numbers"> массив чисел </param>
        /// <returns> сумма сложения каждого второго нечетного числа из массива чисел </returns>
        public async Task<int> GetSumAsync(int[] numbers)
        {
            return await Task.Run(() => SumNumbers(OddNumbers(numbers)));
        }

        /// <summary>
        /// Получение массива нечетных чисел
        /// </summary>
        /// <param name="numbers"> массв </param>
        /// <returns> массив нечетных чисел </returns>
        private int[] OddNumbers(int[] numbers)
        {
            var result = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                    result.Add(number);
            }
            return result.ToArray();
        }

        /// <summary>
        /// Складывает числа чи массива
        /// </summary>
        /// <param name="numbers"> массив нечетных чисел </param>
        /// <returns> сумма сложения каждого второго нечетного числа из массива чисел </returns>
        private int SumNumbers(int[] numbers)
        {
            int sum = 0;
            for (var i = 0; i < numbers.Length; i+=2)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
