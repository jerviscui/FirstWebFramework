using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class MyAspectF
    {
        private Action<Action> _chains;

        public static MyAspectF Define()
        {
            return new MyAspectF();
        }
    }
}
