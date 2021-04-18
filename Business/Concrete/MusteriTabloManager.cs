using Business.Abstract;
using Business.Constraint.Messages.MusteriTablo;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MusteriTabloManager : MusteriTabloService
    {
        private readonly IMusteriTabloDal _musteriManager;
        public MusteriTabloManager(IMusteriTabloDal musteriTabloDal)
        {
            _musteriManager = musteriTabloDal;
        }
        public IResult Add(MusteriTablo musteri)
        {
            if (String.IsNullOrWhiteSpace(musteri.MusteriIsim))
            {
                return new ErrorResult(MusteriTabloMessages.MusteriNameNull);
            }
            if (_musteriManager.Count(x => x.MusteriIsim.Contains(musteri.MusteriIsim) && x.MusteriNumara.Contains(musteri.MusteriNumara)) > 0)
            {
                return new ErrorResult(MusteriTabloMessages.MusteriSameWarning);
            }
            try
            {
                _musteriManager.Add(musteri);
                return new SuccessResult(MusteriTabloMessages.MusteriAdded);
            }
            catch
            {
                return new ErrorResult(MusteriTabloMessages.MusteriNotAdded);
            }
        }

        public IDataResult<bool> Any()
        {
            throw new NotImplementedException();
        }

        public IDataResult<int> Count()
        {
            return new SuccessDataResult<int>(_musteriManager.Count());
        }

        public IResult Delete(MusteriTablo musteri)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriTablo>> GetAll()
        {
            return new SuccessDataResult<List<MusteriTablo>>(_musteriManager.GetAll()); 
        }

        public IDataResult<List<MusteriTablo>> GetAllNonDeleted()
        {
            return new SuccessDataResult<List<MusteriTablo>>(_musteriManager.GetAll(x=>x.Sil==false));
        }

        public IDataResult<MusteriTablo> GetById(int musteriID)
        {
            throw new NotImplementedException();
        }

        public IResult Update(MusteriTablo musteri)
        {
            throw new NotImplementedException();
        }
    }
}
