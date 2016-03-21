using System.Collections.Generic;

namespace Core
{
    public interface IRoleProvider
    {
        string[] GetRolesForUser(string username);

        bool IsUserInRole(string username, string roleName);
    }
}
