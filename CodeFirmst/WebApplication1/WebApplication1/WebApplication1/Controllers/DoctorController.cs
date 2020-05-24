using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorController : ControllerBase
    {


        IDbService _serv;

        public DoctorController(IDbService s)
        {
            _serv = s;
        }

        [HttpGet]
        public IActionResult Index()
        {
            Doctor re = _serv.GetDoctor(3);
            if (re != null)
                return Ok(re);
            return NotFound("Not found");
        }

        [HttpGet("{ID}")]
        public IActionResult GetDoctor(int id)
        {

            Doctor re = _serv.GetDoctor(id);
            if (re != null)
                return Ok(re);
            return NotFound("Not found");

        }

        [HttpPost("{ID}")]
        public IActionResult RemoveDoctor(int id)
        {

            String re = _serv.RemoveDoctor(id);
            if (re == "Ok")
                return Ok("Done");
            return NotFound("error");

        }
        [HttpPost]
        public IActionResult AddDoctor(Doctor doctor)
        {

            String re = _serv.AddDoctor(doctor);
            if (re == "Ok")
                return Ok("Done");
            return NotFound("error");

        }

    }
}