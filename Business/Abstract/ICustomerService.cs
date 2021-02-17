using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer brand);
        IResult Update(Customer brand);
        IResult Delete(Customer brand);
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetById(int Id);
    }
}
