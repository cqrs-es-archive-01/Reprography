
using Reprography.Context.Mapping;
using Reprography.Domain.Features;
using Reprography.Domain.Users;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Reflection;

namespace Reprography.Context
{
    public class ReprographyContext : DbContext
    {

        public ReprographyContext() : base("name=ReprographyConnexionString")
        {
            //Database.SetInitializer<ReprographyContext>(new DropCreateDatabaseIfModelChanges<ReprographyContext>());

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
            .Where(type => !String.IsNullOrEmpty(type.Namespace))
            .Where(type => type.BaseType != null && type.BaseType.IsGenericType &&
                type.BaseType.GetGenericTypeDefinition() == typeof(ReprographyEntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            base.OnModelCreating(modelBuilder);
        }


        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<UserPermission> UserPermissions { get; set; }
        public virtual DbSet<PermissionFeature> PermissionFeatures { get; set; }
                
    }
}
