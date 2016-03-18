using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace WebFramework
{
    public class WebEngine : IEngine
    {
        private readonly IRoleProvider _roleProvider;

        /// <summary>
        /// 初始化 <see cref="T:System.Object"/> 类的新实例。
        /// </summary>
        public WebEngine(IRoleProvider roleProvider)
        {
            _roleProvider = roleProvider;

            Initialize();
        }
        
        public void Initialize()
        {
            //init db setting

            //regist all dependencies
        }
    }
}
