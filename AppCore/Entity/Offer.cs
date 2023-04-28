using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Entity
{
    public class Offer
    {

        #region Property
        public int Id { get; set; }
        public string Description { get; set; }

        [ForeignKey("Order")]
        public int? OrderId { get; set; }
        

        [ForeignKey("Expert")]
        public int? ExpertId { get; set; }
        public double OfferedPrice { get; set; }
        public DateTime Register { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsAccept { get; set; }
        public bool IsDeleted { get; set; }

        #endregion


        #region Navigation Property
        public Order? Order { get; set; }
        public Expert Expert { get; set; }
        #endregion
    }
}
