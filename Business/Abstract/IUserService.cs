using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User brand);
        IResult Update(User brand);
        IResult Delete(User brand);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int Id);
    }
}
