using AnimeFun.Core.Models.AnimeFun;

namespace AnimeFun.Core.Helpers
{
    public static class BaseModelExtensions
    {
        /// <summary>
        /// 有效数据查询
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source">源</param>
        /// <param name="predicate">条件</param>
        /// <returns></returns>
        public static IEnumerable<TSource> WhereVaild<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate) where TSource : BaseModel
        {
            return source.Where(item => !item.Deleted).Where(predicate);
        }
    }
}
