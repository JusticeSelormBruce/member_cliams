using Cliams.Models;
using System;


namespace Cliams.DTOs
{
    public class ClaimDTO
    {
        public DateTime ClaimDate { get; set; }
       
        public Decimal ClaimAmount { get; set; }
        public Member Member { get; set; }
    }
}
