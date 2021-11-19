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
    public class DoctorsController : ControllerBase
    {
        private IDoctorService _doctorService;

        public DoctorsController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet("getall")]
        public IDataResult<List<Doctor>> GetAll()
        {
            return _doctorService.GetAll();
        }

        [HttpPost("Add")]
        public IResult Add(Doctor doctor)
        {
            return _doctorService.Add(doctor);
        }
        [HttpPost("Update")]
        public IResult Update(Doctor doctor)
        {
            return _doctorService.Update(doctor);
        }
        [HttpPost("Delete")]
        public IResult Delete(Doctor doctor)
        {
            return _doctorService.Delete(doctor);
        }


    }
}
