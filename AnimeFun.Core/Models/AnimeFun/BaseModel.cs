namespace AnimeFun.Core.Models.AnimeFun
{
    public abstract class BaseModel
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool Deleted { get; set; }

        protected BaseModel()
        {
            Id = Guid.NewGuid().ToString();
            CreateTime = DateTime.Now;
        }
    }
}
