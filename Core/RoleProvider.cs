using System;
using System.Collections.Generic;

namespace Core
{
    public class RoleProvider : IRoleProvider
    {

        public virtual IEnumerable<string> GetRolesForUser(string user)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsRole(string user, string role)
        {
            throw new NotImplementedException();
        }
    }
}
