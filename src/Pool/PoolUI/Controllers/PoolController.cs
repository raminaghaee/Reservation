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
    [HttpGet("GetAllPool")]
    public ICollection<Pool> GetAllPool()
    {
        return _poolBL.GetAllAsNoTracking();
    }
    [HttpGet("GetNotConfirm")]
    public List<DtoPoolGetCount> GetNotConfirm()
    {
        return _poolBL.GetNotConfirm();
    }
    [HttpGet("GetPoolMaxTicket")]
    public Pool GetPoolMaxTicket()
    {
        return _poolBL.GetPoolMaxTicket();
    }
    [HttpGet("GetPoolMaxNotConfirm")]
    public Pool GetPoolMaxNotConfirm()
    {
        return _poolBL.GetPoolMaxNotConfirm();
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
