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
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SubService> SubServices { get; set; }
    }
}
