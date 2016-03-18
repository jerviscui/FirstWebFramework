using System.Collections.Generic;

namespace Core
{
    public interface IRoleProvider
    {
        IEnumerable<string> GetRolesForUser(string user);

        bool IsRole(string user, string role);
    }
}
