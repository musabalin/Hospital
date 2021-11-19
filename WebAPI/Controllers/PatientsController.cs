using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        IPatientService _patientService;

        public PatientsController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet("Getall")]
        public IResult GetAll()
        {
            return _patientService.GetAll();
        }

        [HttpPost("Add")]
        public IResult Add(Patient patient)
        {
            return _patientService.Add(patient);
        }

        [HttpPost("Delete")]
        public IResult Delete(Patient patient)
        {
            return _patientService.Delete(patient);

        }

        [HttpPost("Update")]
        public IResult Update(Patient patient)
        {
            return _patientService.Update(patient);
        }








    }
}
