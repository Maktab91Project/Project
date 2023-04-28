using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Entity
{
    public class PersonRoles
    {
        public int Id { get; set; }


        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public Person Person { get; set; }


        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; }

    }
}
