using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.Data.Models.Location;

namespace uApply.Data.Models.Education
{
    public class School
    {
        public int Id { get; set; }

        [Display(Name =  "School Name")]
        public string Name { get; set; }
        public long EmisNumber { get; set; }

        [ForeignKey("TownId")]
        public int TownId { get; set; }
        public Town Town { get; set; }

        public IEnumerable<Application> Applications { get; set; }
    }
}
