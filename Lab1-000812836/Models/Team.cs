using System;
using System.ComponentModel.DataAnnotations;

namespace Lab1_TeamMembershipSystem.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name = "Team Name")]
        public string TeamName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true), Display(Name = "Established Date"), DataType(DataType.Date)]
        public DateTime? EstablishedDate { get; set; }
    }
}
