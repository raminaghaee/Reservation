using CMN;

namespace PoolBL;
public interface IBaseDA<T> where T : class, IEntity
{
    #region Get
    T GetById(int id);
    IQueryable<T> GetAllAsQueryable();
    IQueryable<T> GetAllAsQueryable(string[] IncludeList);
    ICollection<T> GetAllAsNoTracking();
    #endregion
    #region Manipulate
    T Insert(T entity);
    bool Update(T entity);
    bool Delete(T entity);
    bool Save();
    #endregion

}
