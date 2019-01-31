using Reprography.Domain.Users;

namespace Reprography.Context.Mapping.Users
{
    public class PermissionMap : ReprographyEntityTypeConfiguration<Permission>
    {
        public PermissionMap()
        {
            ToTable("PERMISSIONS");

            HasKey(a => a.Id);
            Property(a => a.Name).IsRequired().HasMaxLength(150);
            Property(a => a.Description).HasMaxLength(255);

            Property(a => a.CreatedOn).IsRequired();
            Property(a => a.Timestamp).IsRowVersion();

        }
    }
}