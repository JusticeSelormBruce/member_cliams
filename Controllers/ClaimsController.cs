using AutoMapper;
using Cliams.DTOs;
using Cliams.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cliams.Controllers
{
    [Route("api/[Controller]")]
    public class ClaimsController : ControllerBase
    {

        private readonly ITest _test;
        private readonly IMapper _mapper;
        public ClaimsController(ITest test, IMapper mapper)
        {
            _test = test;
            _mapper = mapper;

        }

        [HttpGet("{dateTime}", Name = "GetCliams")]
        public ActionResult<ClaimDTO> GetCliams(string dateTime)
        {



            var claim = _test.GetCliams(dateTime);
            if (claim != null)
            {

                return Ok(claim);

            }
            return NotFound();
        }

    }
}
