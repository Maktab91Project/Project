﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Entity
{
    public class SubService
    {
        #region Property
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        [ForeignKey("MainService")]
        public int? MainServiceId { get; set; }
        #endregion



        #region Navigation Property
        public List<ExpertSubServices> Skills { get; set; }
        public MainService MainService { get; set; }
        #endregion

    }
}
