using Microsoft.AspNetCore.Mvc;
using PoolBL;

namespace PoolUI.Controllers;
[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{

    #region Properties
    private readonly IEmployeeBL _employeeBL;

    public EmployeeController(IEmployeeBL employeeBL)
    {
        _employeeBL = employeeBL;
    }
    #endregion
    #region Get
    [HttpGet]
    public ICollection<Employee> GetAllEmployee()
    {
        return _employeeBL.GetAllAsNoTracking();
    }
    #endregion
    #region Manipulate
    [HttpPost]
    public int PostEmployee(DtoEmployee dtoEmployee)
    {
        return _employeeBL.Insert(dtoEmployee);
    }
    [HttpDelete("{id}")]
    public bool DeleteEmployee(int id)
    {
        return _employeeBL.Delete(id);
    }
    [HttpPut("{id}")]
    public bool PutEmployee(int id, DtoEmployee dtoEmployee)
    {
        return _employeeBL.Update(id, dtoEmployee);
    }
    #endregion

}
