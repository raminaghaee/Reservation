using Microsoft.AspNetCore.Mvc;
using PoolBL;

namespace PoolUI.Controllers;
[ApiController]
[Route("[controller]")]
public class PayController : ControllerBase
{

    #region Properties
    private readonly IPayBL _payBL;

    public PayController(IPayBL payBL)
    {
        _payBL = payBL;
    }
    #endregion
    #region Get
    [HttpGet]
    public ICollection<Pay> GetAllPay()
    {
        return _payBL.GetAllAsNoTracking();
    }
    #endregion
    #region Manipulate
    [HttpPost]
    public int PostUser(DtoPay dtoPay)
    {
        return _payBL.Insert(dtoPay);
    }
    [HttpDelete("{id}")]
    public bool DeletePay(int id)
    {
        return _payBL.Delete(id);
    }
    [HttpPut("{id}")]
    public bool PutPay(int id, DtoPay dtoPay)
    {
        return _payBL.Update(id, dtoPay);
    }
    #endregion

}
