using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uApply.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Surname { get; set; }        
        public int Nationality { get; set; }
        public int Race { get; set; }
        [Display(Name ="Home Language")]
        public int HomeLanguage { get; set; }
        [Display(Name = "Phone number")]
        public int PhoneNumber { get; set; }
        public int Email { get; set; }
        public string Password { get; set; }


        //FOREIGN KEYS
        [ForeignKey("TitleId")]
        public int Title { get; set; }
        [ForeignKey("GenderId")]
        public int Gender { get; set; }

        //NAVIGATION PROPERTIES
        //public Title Title { get; set; }
        //public Gender Gender { get; set; }

        public IEnumerable<Title> Titles { get; set; }
        public IEnumerable<Gender> Genders { get; set; }
    }
}
