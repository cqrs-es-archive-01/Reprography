using System;
using System.Collections.Generic;
using System.Text;

namespace Reprography.Domain.Users
{
    public enum PermissionTypes:int
    {
        Read,
        Write,
        Delete,
        NoAccess    
    }
}
