using System;
using System.Collections.Generic;

namespace JobsAbility.Models
{
    public partial class Messages
    {
        public int Id { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
        public string MessageContent { get; set; }
        public DateTime SendDate { get; set; }
    }
}
