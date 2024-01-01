

namespace PoolBL;
public class UserBl : BaseBL<IUserDA, User ,DtoUser>, IUserBL
{
    private readonly IUserDA _baseDA;

    public UserBl(IUserDA baseDA) : base(baseDA)
    {
        _baseDA = baseDA;
    }

    public int GetCountCoustomerByDateBL(int poolId, DateOnly startDate, DateOnly endDate)
            => _baseDA.GetByDate(poolId, startDate, endDate).Count();

    public int GetCountCoustomerByDateDA(int poolId, DateOnly startDate, DateOnly endDate)
            => _baseDA.GetCountCostumerByDate(poolId, startDate, endDate);

    public int GetCountCoustomerByDateQuery(int poolId, DateOnly startDate, DateOnly endDate)
            => _baseDA.GetIQueryableByDate(poolId, startDate, endDate).Count();
}
