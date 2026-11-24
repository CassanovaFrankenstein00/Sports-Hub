using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sports_Hub.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        [Required]
        public string TeamName { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string Stadium { get; set; } = string.Empty;

        public int Wins { get; set; }

        public int Losses { get; set; }

        [ForeignKey("League")]
        public int LeagueId { get; set; }

        public League? League { get; set; }

        public double WinPercentage
        {
            get
            {
                if (Wins + Losses == 0)
                {
                    return 0;
                }

                return (double)Wins / (Wins + Losses) * 100;
            }
        }
    }
}

