using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Data;

namespace WebFramework
{
    public class DefaultUserProvider : IUserProvider
    {
        private static Func<User> _getUser;

        public DefaultUserProvider(Func<User> getUserFunc)
        {
            _getUser = getUserFunc;
        }

        public User GetUser()
        {
            if (_getUser == null)
            {
                throw new NullReferenceException("Func<User> argument is null reference");
            }

            return _getUser();
        }
    }
}
