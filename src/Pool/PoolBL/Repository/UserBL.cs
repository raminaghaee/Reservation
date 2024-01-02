

namespace PoolBL;
public class UserBl : BaseBL<IUserDA, User ,DtoUser>, IUserBL
{
    public UserBl(IUserDA baseDA) : base(baseDA)
    {

    }
}
