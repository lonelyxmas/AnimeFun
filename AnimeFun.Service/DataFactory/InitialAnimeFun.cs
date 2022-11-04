using AnimeFun.Core.Models.AnimeFun;

namespace AnimeFun.Service.DataFactory
{
    public class InitialAnimeFun
    {
        /// <summary>
        /// 初始化数据
        /// </summary>
        public static void InitialData()
        {
            AnimeFunContext context = new();

            bool state = context.VideoInfos.Any()
                         || context.Episodes.Any()
                         || context.VideoTags.Any()
                         || context.RecommendVideos.Any();
            if (!state)
            {
                List<VideoTag> videoTags = GetVideoTags();
                List<VideoInfo> videoInfos = GetVideoInfos(videoTags);
                context.VideoTags.AddRange(videoTags);
                context.VideoInfos.AddRange(videoInfos);

                context.SaveChanges();
            }
        }

        /// <summary>
        /// 视频标签
        /// </summary>
        /// <returns></returns>
        private static List<VideoTag> GetVideoTags()
        {
            List<VideoTag> videoTags = new();
            for (int i = 0; i < 30; i++)
            {
                videoTags.Add(new VideoTag
                {
                    Name = $"测试视频标签 {i + 1}",
                    Description = $"描述文字。。。"
                });
            }

            return videoTags;
        }

        /// <summary>
        /// 视频信息
        /// </summary>
        /// <param name="videoTags"></param>
        /// <returns></returns>
        private static List<VideoInfo> GetVideoInfos(List<VideoTag> videoTags)
        {
            List<VideoInfo> videoInfos = new();
            for (int i = 0; i < videoTags.Count; i++)
            {
                VideoInfo videoInfo = new()
                {
                    Name = $"测试视频信息 {i + 1}",
                    Description = $"描述文字。。。",
                    Cover = "Test.png"
                };
                videoInfo.VideoTags.Add(videoTags[i]);
                for (int j = 0; j < 24; j++)
                {
                    videoInfo.Episodes.Add(new Episode
                    {
                        Title = $"测试剧集 {i + 1}",
                        Cover = "Test.png",
                        SourceId = "AAAA-BBBB-CCCC-DDDD"
                    });
                }

                videoInfos.Add(videoInfo);
            }

            return videoInfos;
        }
    }
}
