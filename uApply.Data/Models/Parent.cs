using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uApply.Data.Models
{
    public class Parent
    {
        public int Id { get; set; }
        public string FullNames { get; set; }
        public string Surname { get; set; }
        public IEnumerable<Learner> Learners { get; set; }
    }
}
