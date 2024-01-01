using CMN;

namespace PoolBL;
public interface IBaseBL<T,E, D>
    where T : class,IBaseDA<E>
    where E : class,IEntity
    where D : class, IBaseDto

{
    #region Get
    E GetById(int id);
    IQueryable<E> GetAllAsQueryable();
    IQueryable<E> GetAllAsQueryable(string[] IncludeList);
    ICollection<E> GetAllAsNoTracking();
    #endregion
    #region Manipulate
    int Insert(D entity);
    bool Update(int id,D dtoEntity);
    bool Delete(int id);
    //bool Save();
    #endregion

}
