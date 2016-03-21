using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Data;

namespace WebFramework
{
    public static class UserContext
    {
        [ThreadStatic]
        private static User _currentUser;

        private static IUserProvider _userProvider;

        public static User CurrentUser {
            get
            {
                return _currentUser ?? (_currentUser = _userProvider.GetUser());
            }
        }

        /// <summary>
        /// 如果使用ThreadStatic特性，如果从线程池创建线程那么每次线程结束的时候，清理线程级静态变量是很重要的
        /// </summary>
        public static void Clear()
        {
            _currentUser = null;
        }

        public static void Init(IUserProvider userProvider)
        {
            _userProvider = userProvider;
        }
    }
}
