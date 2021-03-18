using Core.Entities.Concrete;
using Core.Utilities.Results;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {

        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByUserId(int id);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);

        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
    }
}
