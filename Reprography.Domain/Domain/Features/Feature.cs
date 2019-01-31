using Reprography.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reprography.Domain.Features
{
    public class Feature:BaseEntity
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Routing { get; set; }

        public virtual ICollection<PermissionFeature> PermissionFeatures { get; set; }

    }
}
