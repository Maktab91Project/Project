using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCore.Enum;

namespace AppCore.Entity
{
    public class Order
    {
        #region Property
        public int Id { get; set; }

        [ForeignKey("customer")]
        public int? CustomerId { get; set; }

        [ForeignKey("Expert")]
        public int? ExpertId { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public int Status { get; set; }
        public bool IsDeleted { get; set; }
        public string Description { get; set; }
        public DateTime DateOfExecution { get; set; }
        public float Price { get; set; }
        

        #endregion


        #region Navigation Property
        public Customer? customer { get; set; }
        public List<SubService> SubServices { get; set; }
        public List<Offer> Offers { get; set; }
        public List<Comment> Comments { get; set; }
        public Expert? Expert { get; set; }
        #endregion


    }
}
