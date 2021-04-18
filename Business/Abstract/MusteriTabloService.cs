using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface MusteriTabloService
    {
        IDataResult<List<MusteriTablo>> GetAll();
        IDataResult<List<MusteriTablo>> GetAllNonDeleted();
        IDataResult<MusteriTablo> GetById(int musteriID);
        IResult Add(MusteriTablo musteri);
        IResult Update(MusteriTablo musteri);
        IResult Delete(MusteriTablo musteri);
        IDataResult<int> Count();
        IDataResult<bool> Any();
    }
}
