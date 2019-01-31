using System;
using System.Collections.Generic;

namespace Reprography.Domain.Users
{
    public class User: BaseEntity
    {
        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<UserPermission> UserPermissions { get; set; }


    }
}
