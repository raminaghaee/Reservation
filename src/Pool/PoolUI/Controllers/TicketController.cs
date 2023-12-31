using Microsoft.AspNetCore.Mvc;
using PoolBL.Dtos;
using PoolBL.IRepository.BL;
using PoolBL;

namespace PoolUI.Controllers;
public class TicketController : ControllerBase
{
    #region Properties
    private readonly Iti _userBL;

    public UserController( userBL)
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
