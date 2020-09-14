using System;
using System.Collections.Generic;

namespace JobsAbility.Models
{
    public partial class JobApplications
    {
        public int? JobPostingId { get; set; }
        public int? RecruiterId { get; set; }
        public int? ApplicantId { get; set; }
        public int Id { get; set; }

        public virtual Users Applicant { get; set; }
        public virtual JobPostings JobPosting { get; set; }
        public virtual Users Recruiter { get; set; }
    }
}
