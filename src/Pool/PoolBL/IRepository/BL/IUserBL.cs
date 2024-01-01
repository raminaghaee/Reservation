namespace PoolBL;
public interface IUserBL : IBaseBL<IUserDA,User,DtoUser>
{
    int GetCountCoustomerByDateBL(int poolId, DateOnly startDate, DateOnly endDate);
    int GetCountCoustomerByDateDA(int poolId, DateOnly startDate, DateOnly endDate);
    int GetCountCoustomerByDateQuery(int poolId, DateOnly startDate, DateOnly endDate);
}
