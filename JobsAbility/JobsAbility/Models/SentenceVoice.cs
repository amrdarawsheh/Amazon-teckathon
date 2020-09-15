using System;
using System.Collections.Generic;

namespace JobsAbility.Models
{
    public partial class SentenceVoice
    {
        public int Id { get; set; }
        public string Sentence { get; set; }
        public string AudioLink { get; set; }
    }
}
