using AnimeFun.Core.Models.AnimeFun;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimeFun.Service.DataFactory.Configurations
{
    public class VideoInfoConfiguration : BaseConfiguration<VideoInfo>
    {
        public override void Configure(EntityTypeBuilder<VideoInfo> builder)
        {
            base.Configure(builder);
        }
    }
}
