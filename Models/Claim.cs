using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cliams.Models
{
    public class Claim
    {
        [Key]
        public int ClaimID { get; set; }
        [Required]
        public DateTime ClaimDate { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public Decimal ClaimAmount { get; set; }
        [Required]
        public Member Member { get; set; }
    }
}
