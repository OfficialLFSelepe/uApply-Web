using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uApply.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullNames { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public long IdNumber{ get; set; }
        public string Race { get; set; }
        public string HomeLanguage { get; set; }
        public string StreetAddress { get; set; }
        public string Surburb { get; set; }
        public int PostalCode { get; set; }
        public string Town { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password{ get; set; }

        public string Role { get; set; }
    }
}
