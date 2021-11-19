using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDoctorService
    {
        IDataResult<List<Doctor>> GetAll();
        IResult Add(Doctor doctor);
        IResult Update(Doctor doctor);
        IResult Delete(Doctor doctor);

    }
}
