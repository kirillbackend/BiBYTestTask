using TestTask.Services.Interface;

namespace TestTask.Services
{
    public class NumbersSortService : ISort
    {
        /// <summary>
        /// Сервис для сортировки массива
        /// </summary>
        /// <param name="array"> неосортированный массиив </param>
        /// <returns> отсортированный массив </returns>
        public async Task<int[]> GerSort(int[] array)
        {
           return await Task.Run(()=> QuickSort(array, 0, array.Length-1));
        }

        /// <summary>
        /// Алгоритм быстрой сортировки
        /// </summary>
        /// <param name="array"> неосортированный массиив </param>
        /// <param name="leftIndex"> начало сортивроки в массиве </param>
        /// <param name="rightIndex"> конец сортировки в массиве </param>
        /// <returns> отсортированный массив </returns>
        public int[] QuickSort(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                QuickSort(array, leftIndex, j);
            if (i < rightIndex)
                QuickSort(array, i, rightIndex);
            return array;
        }
    }
}
