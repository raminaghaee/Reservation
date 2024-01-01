using Microsoft.AspNetCore.Mvc;
using PoolBL;
using System.Diagnostics;

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
    //[HttpGet]
    //public ICollection<Ticket> GetAllTicket()
    //{
    //    return _ticketBL.GetAllAsNoTracking();
    //}
    [HttpGet("{poolId}")]
    public string GetCountCustomerPoolByDateBl(int poolId , string start , string end)
    {
        DateOnly startDate = DateOnly.Parse(start);
        DateOnly endDate = DateOnly.Parse(end);
        Stopwatch stopwatch = Stopwatch.StartNew();
        var result = _ticketBL.GetCountCoustomerByDateBL(poolId,startDate,endDate);
        stopwatch.Stop();
        return $"Time : {stopwatch.Elapsed} ,  Result : {result}";
    }
    [HttpGet("{poolId},{start}")]
    public string GetCountCustomerPoolByDateDA(int poolId, string start, string end)
    {
        DateOnly startDate = DateOnly.Parse(start);
        DateOnly endDate = DateOnly.Parse(end);
        Stopwatch stopwatch = Stopwatch.StartNew();
        var result = _ticketBL.GetCountCoustomerByDateDA(poolId, startDate, endDate);
        stopwatch.Stop();
        return $"Time : {stopwatch.Elapsed} ,  Result : {result}";
    }
    [HttpGet]
    public string GetCountCustomerPoolByDateQuery(int poolId, string start, string end)
    {
        DateOnly startDate = DateOnly.Parse(start);
        DateOnly endDate = DateOnly.Parse(end);
        Stopwatch stopwatch = Stopwatch.StartNew();
        var result = _ticketBL.GetCountCoustomerByDateQuery(poolId, startDate, endDate);
        stopwatch.Stop();
        return $"Time : {stopwatch.Elapsed} ,  Result : {result}";
    }

    [HttpGet("poolName")]
    public int GetCountCustomerPoolByPoolName(string poolName)
    {
        return _ticketBL.GetCountCostumerByPoolName(poolName);
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
