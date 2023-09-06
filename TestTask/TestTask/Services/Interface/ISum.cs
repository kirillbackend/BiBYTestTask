namespace TestTask.Services.Interface
{
    public interface ISum
    {
        Task<int> GetSumAsync(int[] numbers);
    }
}