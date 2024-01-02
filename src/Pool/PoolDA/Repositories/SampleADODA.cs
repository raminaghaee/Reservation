using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using PoolBL;
using System.Data;
using Unity.Policy;
using static CMN.Enums;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace PoolDA.Repositories;
public class SampleAdoDA : ISampleAdoDA
{
    private readonly IConfiguration _configuration;

    public SampleAdoDA(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public int GetCountCostumerByDateADO(int poolId, DateTime startDate, DateTime endDate)
    {
        int count = 0;
        using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("PoolConnectionString")))
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "GetCountCustomer";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PoolId", poolId);
            cmd.Parameters.AddWithValue("@StartDate", startDate);
            cmd.Parameters.AddWithValue("@EndDate", endDate);

            count = Convert.ToInt32(cmd.ExecuteScalar());

            connection.Close();
        }
        return count;
    }
    public ICollection<Ticket> GetCostumerByDateADO(int poolId, DateOnly startDate, DateOnly endDate)
    {


        List<Ticket> reasultList = new List<Ticket>();

        string query = $"SELECT t.ActivedId, t.StartDate, t.EndDate, t.Id" +
     $" \nFROM Pool.Pool p JOIN Pool.Ticket t ON t.PoolId = p.Id WHERE p.Id = @poolId AND t.StartDate >= @startDate AND t.EndDate <= @endDate";

        DataTable dt = new DataTable();
        using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("PoolConnectionString")))
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue($"@poolId", poolId);
                cmd.Parameters.AddWithValue($"@startDate", startDate);
                cmd.Parameters.AddWithValue($"@endDate", endDate);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
              
            }
            catch (Exception)
            {
                throw new Exception();
            }
            finally { con.Close(); }
        }
        if (dt != null && dt.Rows.Count > 0)
            foreach (DataRow row in dt.Rows)
            {
                TicketType type;
                Ticket ticket = new Ticket();
                ticket.ActivedId = (IsActived)row["ActivedId"];
                DateTime start= DateTime.Parse(row["StartDate"].ToString());
                ticket.StartDate = new DateOnly(start.Year, start.Month, start.Day);
                DateTime end= DateTime.Parse(row["EndDate"].ToString());
                ticket.EndDate = new DateOnly(end.Year, end.Month, end.Day); 
                reasultList.Add(ticket);
            }
        return reasultList;

    }
    


}


