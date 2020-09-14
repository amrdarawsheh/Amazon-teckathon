using System;
using System.Collections.Generic;

namespace JobsAbility.Models
{
    public partial class Categories
    {
        public Categories()
        {
            JobPostings = new HashSet<JobPostings>();
            SubCategories = new HashSet<SubCategories>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMain { get; set; }

        public virtual ICollection<JobPostings> JobPostings { get; set; }
        public virtual ICollection<SubCategories> SubCategories { get; set; }
    }
}
