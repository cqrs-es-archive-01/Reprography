
using Reprography.Domain.Features;

namespace Reprography.Context.Mapping.Features
{
    public class FeatureMap: ReprographyEntityTypeConfiguration<Feature>
    {
        public FeatureMap()
        {
            ToTable("FEATURES");
            HasKey(a => a.Id);
            Property(a => a.Name).HasMaxLength(100).IsRequired();
            Property(a => a.Description).HasMaxLength(255).IsRequired();
            Property(a => a.Routing).HasMaxLength(100).IsRequired();
            Property(a => a.CreatedOn).IsRequired();
            Property(a => a.Timestamp).IsRowVersion();

            Property(a => a.CreatedOn).IsRequired();


        }

    }
}