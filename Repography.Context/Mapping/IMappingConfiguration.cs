

using System.Data.Entity;

namespace Reprography.Context.Mapping
{
    public interface IMappingConfiguration
    {
        void ApplyConfiguration(DbModelBuilder modelBuilder);

    }
}