using Microsoft.AspNetCore.Mvc;
using PoolBL;

namespace PoolUI.Controllers;
[ApiController]
[Route("[controller]")]
public class ReservedController : ControllerBase
{

    #region Properties
    private readonly IReservedBL _reservedBL;

    public ReservedController(IReservedBL reservedBL)
    {
        _reservedBL = reservedBL;
    }
    #endregion
    #region Get
    [HttpGet]
    public ICollection<Reserved> GetAllReserved()
    {
        return _reservedBL.GetAllAsNoTracking();
    }
    #endregion
    #region Manipulate
    [HttpPost]
    public int PostReserved(DtoReserved dtoReserved)
    {
        return _reservedBL.Insert(dtoReserved);
    }
    [HttpDelete("{id}")]
    public bool DeleteReserved(int id)
    {
        return _reservedBL.Delete(id);
    }
    [HttpPut("{id}")]
    public bool PutReserved(int id, DtoReserved dtoReserved)
    {
        return _reservedBL.Update(id, dtoReserved);
    }
    #endregion

}
