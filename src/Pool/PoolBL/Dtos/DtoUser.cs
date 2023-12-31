using CMN;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolBL;
public class DtoUser : IBaseDto
{
    
    [MaxLength(20)]
    public string FirstName { get; set; }
    [MaxLength(20)]
    public string LastName { get; set; }
    public byte? Age { get; set; }
    [MaxLength(200)]
    public string? Email { get; set; }
    [MaxLength(50)]
    public string? UserName { get; set; }
    [MaxLength(50)]
    public string? Password { get; set; }
    [MaxLength(13)]
    public string? PhoneNumber { get; set; }
    public int ActivedId { get; set; }
}
