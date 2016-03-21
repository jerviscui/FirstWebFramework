using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using Core;

namespace WebFramework
{
    public class DelegateRoleProvider : RoleProvider, IRoleProvider
    {
        private static Func<string, string[]> _getRolesForUser;

        private static Func<string, string, bool> _isUserInRole;

        public static void Init(Func<string, string[]> userRolesFunc, Func<string, string, bool> isRoleFunc)
        {
            SetGetRolesForUser(userRolesFunc);
            SetIsUserInRole(isRoleFunc);
        }

        public static void SetGetRolesForUser(Func<string, string[]> getRolesForUser)
        {
            _getRolesForUser = getRolesForUser;
        }

        public static void SetIsUserInRole(Func<string, string, bool> isUserInRole)
        {
            _isUserInRole = isUserInRole;
        }

        /// <summary>
        /// 获取一个值，指示指定用户是否属于已配置的 applicationName 的指定角色。
        /// </summary>
        /// <returns>
        /// 如果指定用户属于已配置的 applicationName 的指定角色，则为 true；否则为 false。
        /// </returns>
        /// <param name="username">要搜索的用户名。</param><param name="roleName">作为搜索范围的角色。</param>
        public override bool IsUserInRole(string username, string roleName)
        {
            if (_isUserInRole == null)
            {
                throw new NullReferenceException("Func<string, string, bool> argument is null reference");
            }

            return _isUserInRole(username, roleName);
        }

        /// <summary>
        /// 获取指定用户对于已配置的 applicationName 所属于的角色的列表。
        /// </summary>
        /// <returns>
        /// 一个字符串数组，其中包含指定用户对于已配置的 applicationName 所属于的所有角色的名称。
        /// </returns>
        /// <param name="username">要为其返回角色列表的用户。</param>
        public override string[] GetRolesForUser(string username)
        {
            if (_getRolesForUser == null)
            {
                throw new NullReferenceException("Func<string, string[]> argument is null reference");
            }

            return _getRolesForUser(username);
        }

        /// <summary>
        /// 在数据源中为已配置的 applicationName 添加一个新角色。
        /// </summary>
        /// <param name="roleName">要创建的角色的名称。</param>
        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 从数据源中移除已配置的 applicationName 的角色。
        /// </summary>
        /// <returns>
        /// 如果成功删除角色，则为 true；否则为 false。
        /// </returns>
        /// <param name="roleName">要删除的角色的名称。</param><param name="throwOnPopulatedRole">如果为 true，则在 <paramref name="roleName"/> 具有一个或多个成员时引发异常，并且不删除 <paramref name="roleName"/>。</param>
        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取一个值，该值指示指定角色名是否已存在于已配置的 applicationName 的角色数据源中。
        /// </summary>
        /// <returns>
        /// 如果角色名已存在于已配置的 applicationName 的数据源中，则为 true；否则为 false。
        /// </returns>
        /// <param name="roleName">要在数据源中搜索的角色的名称。</param>
        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 将指定用户名添加到已配置的 applicationName 的指定角色名。
        /// </summary>
        /// <param name="usernames">一个字符串数组，其中包含要添加到指定角色的用户名。</param><param name="roleNames">一个字符串数组，其中包含要将指定用户名添加到的角色的名称。</param>
        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 移除已配置的 applicationName 的指定角色中的指定用户名。
        /// </summary>
        /// <param name="usernames">一个字符串数组，其中包含要从指定角色中移除的用户名。</param><param name="roleNames">一个字符串数组，其中包含要将指定用户名从中移除的角色的名称。</param>
        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取属于已配置的 applicationName 的指定角色的用户的列表。
        /// </summary>
        /// <returns>
        /// 一个字符串数组，其中包含属于已配置的 applicationName 的指定角色的成员的所有用户名。
        /// </returns>
        /// <param name="roleName">一个角色名称，将获取该角色的用户列表。</param>
        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取已配置的 applicationName 的所有角色的列表。
        /// </summary>
        /// <returns>
        /// 一个字符串数组，包含在数据源中存储的已配置的 applicationName 的所有角色的名称。
        /// </returns>
        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取属于某个角色且与指定的用户名相匹配的用户名的数组。
        /// </summary>
        /// <returns>
        /// 一个字符串数组，包含用户名与 <paramref name="usernameToMatch"/> 匹配且用户是指定角色的成员的所有用户的名称。
        /// </returns>
        /// <param name="roleName">作为搜索范围的角色。</param><param name="usernameToMatch">要搜索的用户名。</param>
        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取或设置要存储和检索其角色信息的应用程序的名称。
        /// </summary>
        /// <returns>
        /// 要存储和检索其角色信息的应用程序的名称。
        /// </returns>
        public override string ApplicationName { get; set; }
    }
}
