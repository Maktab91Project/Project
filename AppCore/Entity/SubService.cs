using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Entity
{
    public class SubService
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public List<PersonSubServices> PersonSubServices { get; set; }



        [ForeignKey ("MainService")]
        public int MainServiceId { get; set; }
        public MainService MainService { get; set; }
    }
}
