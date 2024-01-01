using Microsoft.EntityFrameworkCore;
using PoolBL;
using PoolDA.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PoolDA;
public class UserDA : BaseDA<User>, IUserDA
{
    private readonly PoolDbContext _db;

    public UserDA(PoolDbContext Db) : base(Db)
    {
        _db = Db;
    }


}
