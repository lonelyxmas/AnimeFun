namespace AnimeFun.Core.Models.AnimeFun
{
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

        /// <summary>
        /// 关联视频
        /// </summary>
        public List<VideoInfo> VideoInfos { get; set; }
    }
}
