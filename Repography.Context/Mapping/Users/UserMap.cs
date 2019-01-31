using Reprography.Domain.Users;

namespace Reprography.Context.Mapping.Users
{
    public class UserMap:ReprographyEntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("USERS");

            HasKey(a => a.Id);
            Property(a => a.CreatedOn).IsRequired();
            Property(a => a.Email).IsRequired().HasMaxLength(100);
            Property(a => a.FirstName).IsRequired().HasMaxLength(50);
            Property(a => a.LastName).IsRequired().HasMaxLength(50);
            Property(a => a.Timestamp).IsRowVersion();
            Property(a => a.Password).IsMaxLength();
            Property(a => a.IsActive).IsRequired();

        }
    }
}
