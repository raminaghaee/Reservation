using Microsoft.AspNetCore.Mvc;
using PoolBL;

namespace PoolUI.Controllers;
[ApiController]
[Route("[controller]")]
public class SansController : ControllerBase
{

    #region Properties
    private readonly ISansBL _sansBL;

    public SansController(ISansBL sansBL)
    {
        _sansBL = sansBL;
    }
    #endregion
    #region Get
    [HttpGet]
    public ICollection<Sans> GetAllSans()
    {
        return _sansBL.GetAllAsNoTracking();
    }
    #endregion
    #region Manipulate
    [HttpPost]
    public int PostSans(DtoSans dtoSans)
    {
        return _sansBL.Insert(dtoSans);
    }
    [HttpDelete("{id}")]
    public bool DeleteSans(int id)
    {
        return _sansBL.Delete(id);
    }
    [HttpPut("{id}")]
    public bool PutSans(int id, DtoSans dtoSans)
    {
        return _sansBL.Update(id, dtoSans);
    }
    #endregion

}
