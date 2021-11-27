﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uApply.Data.Models
{
    public class SchoolLevel
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("SchoolId")]
        public int SchoolId { get; set; }


    }
}
