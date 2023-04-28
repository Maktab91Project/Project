using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Entity
{
    public class Address
    {
        #region Property


        public int Id { get; set; }
        public string Description { get; set; }


        [ForeignKey("City")]
        public int? CityId { get; set; }

        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }


        //[ForeignKey("Expert")]
        //public int ExpertId { get; set; }
        #endregion


        #region Navigation Property


        public City City { get; set; }
        public Customer Customer { get; set; }
        public Expert Expert { get; set; }
        #endregion



    }
}
