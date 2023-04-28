using AppCore.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Entity
{
    public class Role
    {
        public int RoleId { get; set; }
        public RoleEnum RoleType { get; set; }
        public List<PersonRoles> PersonRoles { get; set; }
    }
}
