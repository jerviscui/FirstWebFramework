using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace WebFramework
{
    public class DelegateRoleProvider : RoleProvider
    {
        private static Func<string, string[]> _getRolesForUser;

        private static Func<string, string, bool> _isUserInRole;

        public DelegateRoleProvider(Func<string, string[]> userRolesFunc, Func<string, string, bool> isRoleFunc)
        {
            _getRolesForUser = userRolesFunc;
            _isUserInRole = isRoleFunc;
        }

        public override IEnumerable<string> GetRolesForUser(string user)
        {
            if (_getRolesForUser == null)
            {
                throw new NullReferenceException("Func<string, string[]> argument is null reference");
            }

            return _getRolesForUser(user);
        }

        public override bool IsRole(string user, string role)
        {
            if (_isUserInRole == null)
            {
                throw new NullReferenceException("Func<string, string, bool> argument is null reference");
            }

            return _isUserInRole(user, role);
        }
    }
}
