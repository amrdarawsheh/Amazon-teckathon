using System;
using System.Collections.Generic;

namespace JobsAbility.Models
{
    public partial class Countries
    {
        public Countries()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Iso { get; set; }
        public string Name { get; set; }
        public string Iso3 { get; set; }
        public int? NumCode { get; set; }
        public int PhoneCode { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
