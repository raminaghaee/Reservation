using Microsoft.AspNetCore.Mvc;
using PoolBL;


namespace PoolUI.Controllers;
[ApiController]
[Route("[controller]")]
public class SampleADOController : Controller
{
    private readonly ISampleAdoDA _sampleAdoDA;

    public SampleADOController(ISampleAdoDA sampleAdoDA)
    {
        _sampleAdoDA = sampleAdoDA;
    }
    [HttpGet]
    public int GetCountCostumer(int poolId , DateTime start, DateTime End )
    {
        return _sampleAdoDA.GetCountCostumerByDateADO(poolId, start, End);
    }
    
    [HttpGet("GetCostumerByDateADO")]
    public ICollection<Ticket> GetCostumerByDateADO(int poolId, DateTime startDate, DateTime EndDate)
    {
        DateOnly start = new DateOnly(startDate.Year,startDate.Month,startDate.Day);
        DateOnly End = new DateOnly(EndDate.Year,EndDate.Month,EndDate.Day);
        return _sampleAdoDA.GetCostumerByDateADO(poolId, start, End);
    }
}
