using AutoMapper;
using Cliams.DTOs;
using Cliams.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cliams.Profiles
{
    public class MemberProfile : Profile
    {
        public MemberProfile()
        {

            CreateMap<Member, MemberDTO>();

            CreateMap<MemberProfile, MemberDTO>();

        }
    }
}
