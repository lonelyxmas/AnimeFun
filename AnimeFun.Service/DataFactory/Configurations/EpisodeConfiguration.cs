using AnimeFun.Core.Models.AnimeFun;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimeFun.Service.DataFactory.Configurations
{
    public class EpisodeConfiguration : BaseConfiguration<Episode>
    {
        public override void Configure(EntityTypeBuilder<Episode> builder)
        {
            base.Configure(builder);
        }
    }
}
