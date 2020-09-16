namespace JobsAbility.Models
{
    public class JobDTO
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Date { get; set; }
        public string Details { get; set; }
        public string LocationLink { get; set; }
        public string Title { get; set; }
        public bool isDeaf { get; set; }
        public bool isBlind { get; set; }
        public bool isAll { get; set; }
    }
}