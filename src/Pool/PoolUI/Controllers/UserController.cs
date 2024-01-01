using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoolBL;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PoolUI.Controllers;
[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{

    #region Properties
    private readonly IUserBL _userBL;

    public UserController(IUserBL userBL)
    {
        _userBL = userBL;
    }
    #endregion
    #region Get
    [HttpGet]
    public ICollection<User> GetAllUser()
    {
        return _userBL.GetAllAsNoTracking();
    }
    
    #endregion
    #region Manipulate
    [HttpPost]
    public int PostUser(DtoUser dtoUser)
    {
        return _userBL.Insert(dtoUser);
    }
    [HttpDelete("{id}")]
    public bool DeleteUser(int id)
    {
        return _userBL.Delete(id);
    }
    [HttpPut("{id}")]
    public bool PutUser(int id, DtoUser dtoUser)
    {
        return _userBL.Update(id, dtoUser);
    }
    #endregion

}
