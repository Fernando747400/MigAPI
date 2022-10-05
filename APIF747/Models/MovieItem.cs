using System.Runtime.InteropServices;

namespace APIF747.Models
{
    public class MovieItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? LeadActor { get; set; }
        public string? SupportActor { get; set; }
        public float CriticScore { get; set; }
        public float AudienceScore { get; set; }
        public string? Synopsis { get; set; }
        public double Budget { get; set; }
        public double Revenue { get; set; }
    }
}
