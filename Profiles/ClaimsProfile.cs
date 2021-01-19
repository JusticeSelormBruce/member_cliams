using AutoMapper;
using Cliams.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Security.Claims;

using System.Threading.Tasks;

namespace Cliams.Profiles
{
    public class ClaimsProfile : Profile
    {
        public ClaimsProfile()
        {

            CreateMap<Claim, ClaimDTO>();

            CreateMap<ClaimsProfile, ClaimDTO>();

        }
       
    }
}
