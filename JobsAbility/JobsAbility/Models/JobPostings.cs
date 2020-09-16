using System;
using System.Collections.Generic;

namespace JobsAbility.Models
{
    public partial class JobPostings
    {
        public JobPostings()
        {
            JobApplications = new HashSet<JobApplications>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public int RecruiterId { get; set; }
        public int CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public int WorkTypeId { get; set; }
        public bool IsDeaf { get; set; }
        public bool IsBlind { get; set; }
        public bool IsAll { get; set; }
        public string DetailsText { get; set; }
        public bool IsActive { get; set; }
        public DateTime AddedDate { get; set; }

        public virtual Categories Category { get; set; }
        public virtual SubCategories SubCategory { get; set; }
        public virtual ICollection<JobApplications> JobApplications { get; set; }
    }
}
