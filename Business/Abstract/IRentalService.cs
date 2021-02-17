using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental brand);
        IResult Update(Rental brand);
        IResult Delete(Rental brand);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int Id);
    }
}
