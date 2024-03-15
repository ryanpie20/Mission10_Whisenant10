using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10_Whisenant.Data
{
    public class BowlerWithTeam
    {
        // Bowler properties
        [Key]
        [Required]
        public int BowlerId { get; set; }
        public string? BowlerLastName { get; set; }
        public string? BowlerFirstName { get; set; }
        public string? BowlerMiddleInit { get; set; }
        public string? BowlerAddress { get; set; }
        public string? BowlerCity { get; set; }
        public string? BowlerState { get; set; }
        public string? BowlerZip { get; set; }
        public string? BowlerPhoneNumber { get; set; }
        [ForeignKey("TeamId")]
        public int? TeamId { get; set; } // This is the foreign key to Team

        // Team properties
        public string? TeamName { get; set; }
    }
}
