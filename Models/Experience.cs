using System;
using System.Collections.Generic;


namespace Evidence_MDetails_SinglePage_Core_CF.Models
{
    public partial class Experience
    {
        public int ExperienceId { get; set; }
        public int? ApplicantId { get; set; }
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        public int? YearsWorked { get; set; }

        public virtual Applicant Applicant { get; set; }
    }
}
