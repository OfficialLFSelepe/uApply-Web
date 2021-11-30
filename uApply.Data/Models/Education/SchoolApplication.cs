using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace uApply.Data.Models.Education
{
    public class SchoolApplication
    {
        public int Id { get; set; }
        public string Status { get; set; }

        public DateTimeOffset Created { get; set; } = DateTimeOffset.Now;

        [ForeignKey("SchoolId")]
        public int SchoolId { get; set; }
        public School School { get; set; }

        [ForeignKey("LearnerId")]
        public int LearnerId { get; set; }
        public Learner Learner { get; set; }

        [ForeignKey("GradeId")]
        public int GradeId { get; set; }
        public Grade Grade { get; set; }


    }
}
