using Reprography.Context;
using Reprography.Domain.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Reprography.Data.Users
{
    public class UserData
    {
        private readonly ReprographyContext _context;

        public UserData(ReprographyContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.Users.AsNoTracking()
                        .Include(p => p.UserPermissions).Where(p => p.IsActive)
                        .ToList();
        }

        public User GetByKey(Guid id)
        {
            return _context.Users.AsNoTracking()
                        .Include(a => a.UserPermissions)
                        .FirstOrDefault(a => a.Id == id);
        }

    }
}
