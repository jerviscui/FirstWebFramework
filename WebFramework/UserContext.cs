using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace WebFramework
{
    public static class UserContext
    {
        [ThreadStatic]
        private static User _currentUser;

        public static User CurrentUser {
            get
            {
                return _currentUser ?? (_currentUser = new User());
            }
        }

        public static void Clear()
        {
            _currentUser = null;
        }
    }
}
