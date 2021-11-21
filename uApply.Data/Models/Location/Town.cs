using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uApply.Data.Models
{
    public class Town
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("DistrictId")]
        public int DistrictId { get; set; }
        public District District { get; set; }
    }
} 
