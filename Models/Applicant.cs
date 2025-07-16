using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Evidence_MDetails_SinglePage_Core_CF.Models
{
    public partial class Applicant
    {
        public Applicant()
        {
            Experience = new List<Experience>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateOnly DOB { get; set; }
        public int? Age { get; set; }
        public string Qualification { get; set; }
        public int? TotalExperience { get; set; }
        public string PhotoUrl { get; set; }


        [NotMapped]
        public IFormFile ProfilePhoto { get; set; }
        public virtual List<Experience> Experience { get; set; }
    }
}
