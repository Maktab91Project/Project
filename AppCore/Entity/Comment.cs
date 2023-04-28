using AppCore.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Entity
{
    public class Comment
    {
        #region Property
        public int Id { get; set; }
        public string? Description { get; set; }
        public int Score { get; set; }
        //public int OrderId { get; set; }


        [ForeignKey("Expert")]
        public int? ExpertId { get; set; }

        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }


        #endregion


        #region Navigation Property
        public Order Order { get; set; }
        public Customer? Customer { get; set; } 
        public Expert? Expert { get; set; } 

        #endregion
    }
}
