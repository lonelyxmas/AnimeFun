using AnimeFun.Core.Models.AnimeFun;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimeFun.Service.DataFactory.Configurations
{
    public class VideoTagConfiguration : BaseConfiguration<VideoTag>
    {
        public override void Configure(EntityTypeBuilder<VideoTag> builder)
        {
            base.Configure(builder);
        }
    }
}
