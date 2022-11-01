namespace AnimeFun.Core.Models.AnimeFun
{
    public class VideoInfo : BaseModel
    {
        /// <summary>
        /// 视频名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 视频描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 视频封面
        /// </summary>
        public string Cover { get; set; }

        /// <summary>
        /// 视频标签
        /// </summary>
        public List<VideoTag> VideoTags { get; set; }

        /// <summary>
        /// 剧集
        /// </summary>
        public List<Episode> Episodes { get; set; }
    }
}
