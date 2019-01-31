using System.Data.Entity;

namespace Reprography.Context
{
    public class ReprographyContextConfig : DbConfiguration
    {
        public ReprographyContextConfig()
        {
            this.SetDatabaseInitializer(new NullDatabaseInitializer<ReprographyContext>());
        }
    }
}
