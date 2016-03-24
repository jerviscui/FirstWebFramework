﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Core;
using Data;

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
            Init(null);
        }

        public static void Init(IUserProvider userProvider, Action<ContainerBuilder> registerControllersAction)
        {
            _currentEngine = new WebEngine(userProvider, registerControllersAction);
        }

        public static void Init(Action<ContainerBuilder> registerControllersAction)
        {
            _currentEngine = new WebEngine(registerControllersAction);
        }
    }
}
