using System;
using System.Collections.Generic;

namespace JobsAbility.Models
{
    public partial class Users
    {
        public Users()
        {
            JobApplicationsApplicant = new HashSet<JobApplications>();
            JobApplicationsRecruiter = new HashSet<JobApplications>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? DisabilityId { get; set; }
        public int? RoleId { get; set; }
        public int? CountryId { get; set; }
        public int? CompanyId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public virtual Company Company { get; set; }
        public virtual Countries Country { get; set; }
        public virtual Disabilities Disability { get; set; }
        public virtual Roles Role { get; set; }
        public virtual ICollection<JobApplications> JobApplicationsApplicant { get; set; }
        public virtual ICollection<JobApplications> JobApplicationsRecruiter { get; set; }
    }
}
