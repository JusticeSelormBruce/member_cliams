using Cliams.Interface;
using Cliams.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

using System.Globalization;

namespace Cliams.Data
{
    public class ClaimsRepository :ITest
    {

        private readonly IFormatProvider provider;

        private readonly ApplicationDbContext _applicationDb;
        public ClaimsRepository( ApplicationDbContext applicationDb)
        {
            _applicationDb = applicationDb;
        }

        public Claim GetCliams(string ClaimDate)
        {

            DateTime date = DateTime.Parse(ClaimDate);
            return _applicationDb.Cliams.Include(c => c.Member).FirstOrDefault(opt => opt.ClaimDate == date);
        }
    }
}
