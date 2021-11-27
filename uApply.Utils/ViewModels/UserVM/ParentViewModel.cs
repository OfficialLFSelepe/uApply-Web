using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.Data.Models;

namespace uApply.Utils.ViewModels.UserVM
{
    public class ParentViewModel
    {
        public Parent Parent { get; set; }
        public IEnumerable<SelectListItem> Titles { get; set; }
        public IEnumerable<SelectListItem> Genders { get; set; }
        public IEnumerable<SelectListItem> Races { get; set; }
        public IEnumerable<SelectListItem> Nationalities { get; set; }
        public IEnumerable<SelectListItem> Languages { get; set; }
        public IEnumerable<Learner> Learners { get; set; }
    }
}
