using TestTask.Services.Interface;

namespace TestTask.Services
{
    public class SumModuloService : ISum
    {
        public async Task<int> GetSumAsync(int[] numbers)
        {
            return await Task.Run(() => SumNumbers(OddNumbers(numbers)));
        }

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
