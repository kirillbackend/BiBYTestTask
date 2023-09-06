namespace TestTask.Services.Interface
{
    public interface ISort
    {
        /// <summary>
        /// Интерфейс для сортировки массива 
        /// </summary>
        /// <param name="array"> Массив </param>
        /// <returns> отсортированый массив </returns>
        Task<int[]> GerSort(int[] array);
    }
}