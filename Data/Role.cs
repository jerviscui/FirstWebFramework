using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Role
    {
        public string RoleName { get; set; }

        public ICollection<Permission> Permissions { get; set; }
    }
}
