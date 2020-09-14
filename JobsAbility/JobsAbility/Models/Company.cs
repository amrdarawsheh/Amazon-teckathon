using System;
using System.Collections.Generic;

namespace JobsAbility.Models
{
    public partial class Company
    {
        public Company()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
