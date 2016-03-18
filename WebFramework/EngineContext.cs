using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFramework
{
    public class EngineContext
    {
        private static IEngine _currentEngine;

        public static IEngine Engine
        {
            get { return _currentEngine; }
        }

        public static void Init()
        {
            _currentEngine = new WebEngine(new DelegateRoleProvider(null, null));
        }


    }
}
