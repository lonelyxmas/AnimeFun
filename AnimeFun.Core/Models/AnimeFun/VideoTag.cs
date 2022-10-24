namespace AnimeFun.Core.Models.AnimeFun
{
    /// <summary>
    /// 视频标签
    /// </summary>
    public class VideoTag : BaseModel
    {
        /// <summary>
        /// 标签名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 标签描述
        /// </summary>
        public string Description { get; set; }
    }
}
