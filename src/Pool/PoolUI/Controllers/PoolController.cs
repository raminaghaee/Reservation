using Microsoft.AspNetCore.Mvc;
using PoolBL;

namespace PoolUI.Controllers;
[ApiController]
[Route("[controller]")]
public class PoolController : ControllerBase
{

    #region Properties
    private readonly IPoolBL _poolBL;

    public PoolController(IPoolBL poolBL)
    {
        _poolBL = poolBL;
    }
    #endregion
    #region Get
    [HttpGet]
    public ICollection<Pool> GetAllUser()
    {
        return _poolBL.GetAllAsNoTracking();
    }
    #endregion
    #region Manipulate
    [HttpPost]
    public int PostPool(DtoPool dtoPool)
    {
        return _poolBL.Insert(dtoPool);
    }
    [HttpDelete("{id}")]
    public bool DeletePool(int id)
    {
        return _poolBL.Delete(id);
    }
    [HttpPut("{id}")]
    public bool PutPool(int id, DtoPool dtoPool)
    {
        return _poolBL.Update(id, dtoPool);
    }
    #endregion

}
