using Reprography.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Reprography.Context.Mapping
{
    public class ReprographyEntityTypeConfiguration<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        protected ReprographyEntityTypeConfiguration()
        {
            PostInitialize();
        }

        protected virtual void PostInitialize()
        {

        }

    }
}