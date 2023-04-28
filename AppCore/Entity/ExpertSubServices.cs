using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Entity
{
    public class ExpertSubServices
    {
        #region Property
        public int Id { get; set; }

        [ForeignKey("Expert")]
        public int? ExpertId { get; set; }


        [ForeignKey("SubService")]
        public int? SubServiceId { get; set; }
        #endregion


        #region Navigation Property
        public SubService SubService { get; set; }
        public Expert? Expert { get; set; }
        #endregion

    }
}
