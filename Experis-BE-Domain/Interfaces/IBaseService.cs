namespace Experis_BE_Domain.Interfaces
{
    public interface IBaseService<in T> where T : class
    {
        Task<IResponse> Insert(T obj);
        Task<IResponse> Update(T obj);
        Task<IResponse> Delete(Guid id);
        Task<IResponse> GetAll(int page, int size);
        Task<IResponse> GetById(Guid id);
    }
}
