using AnimeFun.Core.Models.AnimeFun;
using AnimeFun.Service.DataFactory.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AnimeFun.Service.DataFactory
{
    public class AnimeFunContext : DbContext
    {
        /// <summary>
        /// 视频信息
        /// </summary>
        public DbSet<VideoInfo> VideoInfos { get; set; }

        /// <summary>
        /// 剧集
        /// </summary>
        public DbSet<Episode> Episodes { get; set; }

        /// <summary>
        /// 视频标签
        /// </summary>
        public DbSet<VideoTag> VideoTags { get; set; }

        /// <summary>
        /// 推荐视频
        /// </summary>
        public DbSet<RecommendVideo> RecommendVideos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=AnimeFun;Persist Security Info=True;User ID=sa;Password=wangxi55");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VideoInfoConfiguration());
            modelBuilder.ApplyConfiguration(new EpisodeConfiguration());
            modelBuilder.ApplyConfiguration(new VideoTagConfiguration());
            modelBuilder.ApplyConfiguration(new RecommendVideoConfiguration());
        }
    }
}
