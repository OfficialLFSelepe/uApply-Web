using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.Data.Models.Location;

namespace uApply.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

        [Required]
        [DisplayName("Full Names")]
        public string FullNames { get; set; }
        public string Surname { get; set; }
        public long IdNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string StreetAddress { get; set; }
        public string Surburb { get; set; }
        public int PostalCode { get; set; }

        [ForeignKey("TownId")]
        public int TownId { get; set; }
        public Town Town { get; set; }


        //FOREIGN KEYS
        [ForeignKey("TitleId")]
        public int TitleId { get; set; }
        public Title Title { get; set; }

        [ForeignKey("GenderId")]
        public int GenderId { get; set; }
        public Gender Gender { get; set; }

        [ForeignKey("NationalityId")]
        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; }


        [ForeignKey("RaceId")]
        public int RaceId { get; set; }
        public Race Race { get; set; }


        [ForeignKey("LanguageId")]//HL
        public int LanguageId { get; set; }

        [Display(Name = "Home Langnuage")]
        public Language Language { get; set; }


        

    }
}
