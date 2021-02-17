using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental brand)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Rental brand)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Rental> GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Rental brand)
        {
            throw new System.NotImplementedException();
        }
    }
}
