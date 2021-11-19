using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IClinicService
    {
        IResult Add(Clinic clinic);
        IResult Delete(Clinic clinic);
        IResult Update(Clinic clinic);
       IDataResult<List<Clinic>> GetAll();
    }
}
