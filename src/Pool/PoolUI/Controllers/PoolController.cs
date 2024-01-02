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
    [HttpGet("GetNotConfirm/{startDateTime},{endDateTime}")]
    public List<DtoPoolGetCount> GetNotConfirm(DateTime startDateTime, DateTime endDateTime)
    {
        return _poolBL.GetNotConfirm(startDateTime,endDateTime);
    }
    [HttpGet("GetPoolMaxTicket/{startDateTime},{endDateTime}")]
    public Pool GetPoolMaxTicket(string startDate, string endDate)
    {
        DateOnly start = DateOnly.Parse(startDate);
        DateOnly end = DateOnly.Parse(endDate);
        return _poolBL.GetMaxTickets(start, end);
    }
    [HttpGet("GetPoolMaxNotConfirm/{startDateTime} ,{endDateTime}")]
    public Pool GetPoolMaxNotConfirm(DateTime startDateTime, DateTime endDateTime)
    {
        return _poolBL.GetMaxNotConfirm(startDateTime,endDateTime);
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
