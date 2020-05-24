using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    [Route("api/medi")]
    [ApiController]
    public class MediController : ControllerBase
    {

        private readonly ClinDbContext _context;

        public MediController(ClinDbContext context)
        {

            _context = context;

        }
        public IActionResult Index()
        {
            return Ok("JD");
        }
    }
}