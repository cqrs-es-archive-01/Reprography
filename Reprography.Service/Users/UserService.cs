using Reprography.Data.Users;
using Reprography.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reprography.Service.Users
{
    public class UserService
    {
        private readonly UserData _userData;
        public UserService(UserData userData)
        {
            _userData = userData;
        }



        public List<User> GetAll()
        {
            return _userData.GetAll();
        }
        public User GetByKey(Guid id)
        {
            return _userData.GetByKey(id);
        }
    }
}
