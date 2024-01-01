

namespace PoolBL;
public class UserBl : BaseBL<IUserDA, User ,DtoUser>, IUserBL
{
    private readonly IUserDA _baseDA;

    public UserBl(IUserDA baseDA) : base(baseDA)
    {
        _baseDA = baseDA;
    }

   
}
