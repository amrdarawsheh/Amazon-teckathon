using System;
using System.Collections.Generic;

namespace JobsAbility.Models
{
    public partial class SubCategories
    {
        public SubCategories()
        {
            JobPostings = new HashSet<JobPostings>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public bool? IsMain { get; set; }

        public virtual Categories Category { get; set; }
        public virtual ICollection<JobPostings> JobPostings { get; set; }
    }
}
