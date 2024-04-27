namespace HRWASMConsumer.Services
{
    public interface IServices<T>
    {
        //CRUD
        Task<List<T>> GetAll();
        Task<T> GetByID(int id);
        Task Insert(T item);
        Task Update(int id, T item);
        Task Delete(int id);
    }
}
