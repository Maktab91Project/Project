using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Entity
{
    public class PersonSubServices
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        [ForeignKey ("Persons")]
        public int PersonId { get; set; }
        public Person Persons { get; set; }



        [ForeignKey("SubServices")]
        public int MainServicesId { get; set; }
        public SubService SubServices { get; set; }
    }
}
