using AppCore.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Entity
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? Score { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public List<PersonSubServices> PersonSubServices { get; set; }
        public List <PersonRoles> PersonRoles { get; set; }


    }
}
