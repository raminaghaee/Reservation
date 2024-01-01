using Microsoft.AspNetCore.Mvc;
using PoolBL;

namespace PoolUI.Controllers;
[ApiController]
[Route("[controller]")]
public class ConstantController : ControllerBase
{

    #region Properties
    private readonly IConstantBL _constantBL;

    public ConstantController(IConstantBL constantBL)
    {
        _constantBL = constantBL;
    }
    #endregion
    #region Get
    [HttpGet]
    public ICollection<Constant> GetAllConstant()
    {
        return _constantBL.GetAllAsNoTracking();
    }
    #endregion
    #region Manipulate
    [HttpPost]
    public int PostUser(DtoConstant dtoConstant)
    {
        return _constantBL.Insert(dtoConstant);
    }
    [HttpDelete("{id}")]
    public bool DeleteConstant(int id)
    {
        return _constantBL.Delete(id);
    }
    [HttpPut("{id}")]
    public bool PutConstant(int id, DtoConstant dtoConstant)
    {
        return _constantBL.Update(id, dtoConstant);
    }
    #endregion

}
