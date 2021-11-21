﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uApply.Data.Models
{
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("ProvinceId")]
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
    }
}
