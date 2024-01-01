using Microsoft.AspNetCore.Mvc;
using PoolBL;

namespace PoolUI.Controllers;
[ApiController]
[Route("[controller]")]
public class TicketController : ControllerBase
{

    #region Properties
    private readonly ITicketBL _ticketBL;

    public TicketController(ITicketBL ticketBL)
    {
        _ticketBL = ticketBL;
    }
    #endregion
    #region Get
    [HttpGet]
    public ICollection<Ticket> GetAllTicket()
    {
        return _ticketBL.GetAllAsNoTracking();
    }


    #endregion
    #region Manipulate
    [HttpPost]
    public int PostTicket(DtoTicket dtoTicket)
    {
        return _ticketBL.Insert(dtoTicket);
    }
    [HttpDelete("{id}")]
    public bool DeleteTicket(int id)
    {
        return _ticketBL.Delete(id);
    }
    [HttpPut("{id}")]
    public bool PutTicket(int id, DtoTicket dtoTicket)
    {
        return _ticketBL.Update(id, dtoTicket);
    }
    #endregion

}
