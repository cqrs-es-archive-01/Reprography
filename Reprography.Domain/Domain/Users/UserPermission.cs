using Reprography.Domain.Features;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reprography.Domain.Users
{
    public class UserPermission :BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid PermissionId { get; set; }

        public virtual User User { get; set; }
        public virtual Permission Permission { get; set; }
    }
}
