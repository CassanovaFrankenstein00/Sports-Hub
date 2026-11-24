using System.ComponentModel.DataAnnotations;

namespace Sports_Hub.Models
{
    public class League
    {
        [Key]
        public int LeagueId { get; set; }

        [Required]
        public string LeagueName { get; set; } = string.Empty;

        [Required]
        public string Sport { get; set; } = string.Empty;
    }
}

