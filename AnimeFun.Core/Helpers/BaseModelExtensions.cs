using AnimeFun.Core.Models.AnimeFun;

namespace AnimeFun.Core.Helpers
{
    public static class BaseModelExtensions
    {
        /// <summary>
        /// 排序查询
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source">源</param>
        /// <param name="predicate">条件</param>
        /// <param name="deleted">是否删除</param>
        /// <returns></returns>
        public static IEnumerable<TSource> WhereSort<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, bool deleted = false) where TSource : BaseModel
        {
            return source.Where(item => item.Deleted == deleted).Where(predicate).OrderBy(item => item.Sort);
        }
    }
}
