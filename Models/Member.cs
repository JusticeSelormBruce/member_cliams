using System;
using System.ComponentModel.DataAnnotations;

namespace Cliams.Models
{
    public class Member
    {
        [Key]
        public int MemberID { get; set; }
        [Required]
        public DateTime EnrollmentDate { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
