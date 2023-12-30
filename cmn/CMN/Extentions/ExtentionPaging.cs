using System.Collections.Generic;
using System.Linq;

namespace CMN.Extentions
{
    public static class ExtentionPaging
    {
        public static IEnumerable<T> Page<T>(this IEnumerable<T> data, ushort pageIndex, ushort pageSize)
                      => data.Skip((pageIndex - 1) * pageSize).Take(pageSize);

        public static IEnumerable<T> FirstPage<T>(this IEnumerable<T> data, ushort pageSize) 
                      => data.Take(pageSize);
        
        public static IEnumerable<T> LastPage<T>(this IEnumerable<T> data, ushort pageSize)
                      => data.Skip(((data.Count() / pageSize) - 1) * pageSize).Take(pageSize);
        
        public static int CountOfPage<T>(this IEnumerable<T> data, ushort pageSize)
        {
            var total = data.Count();
            return (total / pageSize) + (total % pageSize) > 0 ? 1 : 0;
        }
    }
}
