namespace AnimeFun.Core.Models.AnimeFun
{
    public abstract class BaseModel
    {
        /// <summary>
        /// 主键
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; private set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; private set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool Deleted { get; set; }
    }
}
