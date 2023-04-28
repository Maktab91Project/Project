using AppCore.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Entity
{
    public class MainService
    {
        #region Property
        public int Id { get; set; }
        public string Name { get; set; }       
        public bool IsDeleted { get; set; }
        public string ImgSrc { get; set; }
        #endregion


        #region Navigation Property
        public List<SubService> SubServices { get; set; }
        #endregion
    }
}
