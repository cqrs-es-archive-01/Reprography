using Reprography.Domain.Features;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reprography.Domain.Users
{
    public class Permission: BaseEntity
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public virtual ICollection<PermissionFeature> PermissionFeatures { get; set; }
        public virtual ICollection<UserPermission> UserPermissions { get; set; }

    }
}
