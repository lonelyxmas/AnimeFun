using AnimeFun.Core.Models.AnimeFun;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimeFun.Service.DataFactory.Configurations
{
    public class RecommendVideoConfiguration : BaseConfiguration<RecommendVideo>
    {
        public override void Configure(EntityTypeBuilder<RecommendVideo> builder)
        {
            base.Configure(builder);
        }
    }
}
