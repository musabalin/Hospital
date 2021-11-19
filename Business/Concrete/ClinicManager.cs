using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   public class ClinicManager:IClinicService
    {
        IClinicDal _clinicDal;
        public ClinicManager(IClinicDal clinicDal)
        {
            _clinicDal = clinicDal;
        }

        public IResult Add(Clinic clinic)
        {
            _clinicDal.Add(clinic);
            return new SuccessResult("Klinik Eklendi");
        }

        public IResult Delete(Clinic clinic)
        {
            _clinicDal.Delete(clinic);
            return new SuccessResult("Klinik Silindi");

        }

        public IDataResult<List<Clinic>> GetAll()
        {
            return new SuccessDataResult<List<Clinic>>(_clinicDal.GetAll(),"Klinikler Listlendi");
        }

        public IResult Update(Clinic clinic)
        {
            _clinicDal.Update(clinic);
            return new SuccessResult("Klinik güncellendi");
        }
    }
}
