using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.Data.Models;

namespace uApply.Utils.ViewModels.UserVM
{
    public class LearnerViewModel
    {
        public Learner Learner { get; set; }

        public IEnumerable<SelectListItem> Grades { get; set; }
        public IEnumerable<SelectListItem> SchoolLevel { get; set; }

    }
}
