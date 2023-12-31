using Microsoft.EntityFrameworkCore;
using PoolBL;
using PoolDA.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolDA;
public class UserDA : BaseDA<User>, IUserDA
{
    public UserDA(PoolDbContext Db) : base(Db)
    {
    }
}
