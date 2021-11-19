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
    public class ClinicsController : ControllerBase
    {
        private IClinicService _clinicService;

        public ClinicsController(IClinicService clinicService)
        {
            _clinicService = clinicService;
        }

        [HttpGet("GetAll")]
        public IResult GetAll()
        {
            return _clinicService.GetAll();
        }
        [HttpPost("Add")]
        public IResult Add(Clinic clinic)
        {
            return _clinicService.Add(clinic);
        }
        [HttpPost("update")]
        public IResult Update(Clinic clinic)
        {
            return _clinicService.Update(clinic);
        }
        [HttpPost("Delete")]
        public IResult Delete(Clinic clinic)
        {
            return _clinicService.Delete(clinic);
        }


    }
}
