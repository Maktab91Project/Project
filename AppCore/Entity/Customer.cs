using AppCore.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Entity
{
    public class Customer
    {
        #region Property
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Phone { get; set; }
        public string? ImgUrl { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Register { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        #endregion

        #region Navigation Property
        public List<Address> Address { get; set; }
        public List<Order> Orders { get; set; }
        public List<Comment> Comments { get; set; }

        #endregion  

    }
}
