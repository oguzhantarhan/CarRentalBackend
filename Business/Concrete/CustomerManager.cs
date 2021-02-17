using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer brand)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Customer brand)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Customer> GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Customer brand)
        {
            throw new System.NotImplementedException();
        }
    }
}
