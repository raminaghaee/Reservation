using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace CMN;
public static class ExtentionDynamicSearch
{
    public static IEnumerable<T> DynamicGet<T>(this IQueryable<T> query, Expression<Func<T, bool>> where = null
                                                   , Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includes = "")
        where T : class
    {
        if (where != null)
            query = query.Where(where);

        if (orderby != null)
            query = orderby(query);

        if (includes != "")
        {
            foreach (string include in includes.Split(','))
            {
                query = query.Include(include);
            }
        }
        return query.ToList();
    }
}


