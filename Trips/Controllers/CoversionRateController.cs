using Interview_Asseement.Models;
using Interview_Asseement.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Trips.Repository;

namespace Trips.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoversionRateController : Controller
    {

      
        private readonly IMetricConversionService _data;

        public CoversionRateController(IMetricConversionService data)
        {
            _data = data;
        }



        [HttpGet]
        public ActionResult<List<Units>> Get()
        {

            //convert
            return Ok(_data.ConvertTemperature());

        }


        [HttpGet("/Area")]
        public ActionResult<List<Units>> GetArea()
        {

            //convert
            return Ok(_data.ConvertArea());

        }
        [HttpGet("/length")]
        public ActionResult<List<Units>> GetLength()
        {

            //convert
            return Ok(_data.Convertlength());

        }
    }
}
