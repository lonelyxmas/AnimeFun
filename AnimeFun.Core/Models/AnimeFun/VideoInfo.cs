﻿namespace AnimeFun.Core.Models.AnimeFun
{
    /// <summary>
    /// 视频信息
    /// </summary>
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
        /// 视频标签
        /// </summary>
        public List<VideoTag> VideoTags { get; set; } = new List<VideoTag>();

        /// <summary>
        /// 剧集
        /// </summary>
        public List<Episode> Episodes { get; set; } = new List<Episode>();
    }
}
