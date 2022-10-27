namespace AnimeFun.Core.Models.AnimeFun
{
    public class RecommendVideo : BaseModel
    {
        /// <summary>
        /// 视频Id
        /// </summary>
        public string VideoInfoId { get; set; }

        /// <summary>
        /// 剧集Id
        /// </summary>
        public string EpisodeId { get; set; }

        /// <summary>
        /// 推荐理由
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 推荐封面
        /// </summary>
        public string Cover { get; set; }
    }
}
