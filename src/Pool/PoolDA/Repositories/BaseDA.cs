using CMN;
using Microsoft.EntityFrameworkCore;
using PoolBL;
using PoolDA.Contexts;

namespace PoolDA;
public abstract class BaseDA<T> : IBaseDA<T>
       where T : class, IEntity
{

    #region Property
    public BaseDA(PoolDbContext Db)
    {
        _db = Db;
    }
    private PoolDbContext _db;


    #endregion
    #region Manipulate
    public bool Delete(T entity)
    {
        try
        {
            _db.Entry(entity).State = EntityState.Deleted;
            Save();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return true;
    }

    public T Insert(T entity)
    {
        _db.Entry(entity).State = EntityState.Added;
        try
        {
            Save();
            return entity;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public bool Save()
    {
        var enitites = _db.ChangeTracker.Entries().Where(i => i.State != EntityState.Unchanged || i.State != EntityState.Detached);

        foreach (var item in enitites)
        {
            try
            {
                if (item.State == EntityState.Added)
                {
                    (item.Entity as IEntity).Id = GetAllAsQueryable().Any() ? GetAllAsQueryable().Max(i => i.Id) + 1 : 1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        try
        {
            _db.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);

        }
        return true;
    }

    public bool Update(T entity)
    {
        try
        {
            _db.Entry(entity).State = EntityState.Modified;
            Save();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return true;
    }
    #endregion
    #region Get
    public ICollection<T> GetAllAsNoTracking()
            => GetAllAsQueryable().AsNoTracking().ToList();

    public IQueryable<T> GetAllAsQueryable()
            => _db.Set<T>();
    public T GetById(int id)
            => GetAllAsQueryable().Where(i => i.Id == id).Single();


    public IQueryable<T> GetAllAsQueryable(string[] IncludeList)
    {
        IQueryable<T> query = GetAllAsQueryable();
        foreach (var item in IncludeList)
        {
            query = query.Include(item);
        }
        return query;
    }


    #endregion





}
