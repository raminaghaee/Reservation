using CMN;
using CMN.Extentions;

namespace PoolBL;
public abstract class BaseBL<T, E, D> : IBaseBL<T, E, D>
        where T : class, IBaseDA<E>
        where E : class, IEntity, new()
        where D : class, IBaseDto
{
    private readonly T _baseDA;
    public BaseBL(T baseDA)
    {
        _baseDA = baseDA;
    }
    #region Properties

    #endregion
    #region Get
    public virtual ICollection<E> GetAllAsNoTracking()
    {
        return _baseDA.GetAllAsNoTracking();
    }

    public virtual IQueryable<E> GetAllAsQueryable()
    {
        return _baseDA.GetAllAsQueryable();
    }

    public virtual IQueryable<E> GetAllAsQueryable(string[] IncludeList)
    {
        return _baseDA.GetAllAsQueryable(IncludeList);
    }

    public virtual E GetById(int id)
    {

        return _baseDA.GetById(id);
    }

    #endregion
    #region Manipulate
    public virtual bool Delete(int id)
    {
        var entity = _baseDA.GetById(id);
        return _baseDA.Delete(entity);
    }
    public virtual int Insert(D dtoEntity) => _baseDA.Insert(dtoEntity.Map<E, D>()).Id;

    public virtual bool Update(int id, D dtoEntity)
    {
        E entity = _baseDA.GetById(id);
        return _baseDA.Update(dtoEntity.Map(entity));
    }

    protected virtual bool Save() => _baseDA.Save();

    #endregion

}
