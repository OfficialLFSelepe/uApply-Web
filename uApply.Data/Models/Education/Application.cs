using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace uApply.Data.Models.Education
{
    public class Application
    {
        public int Id { get; set; }
        public string Status { get; set; }

        [ForeignKey("SchoolId")]
        public int SchoolId { get; set; }
        public School School { get; set; }

        //Notify on status change --- > SMS

    }
}
