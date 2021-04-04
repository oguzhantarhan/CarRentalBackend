using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                {
                    var result = from r in filter == null ? context.Rentals : context.Rentals.Where(filter)
                                 join c in context.Cars
                                 on r.CarId equals c.Id
                                 join b in context.Brands
                                 on c.BrandId equals b.Id
                                 join cs in context.Customers
                                 on r.CustomerId equals cs.Id
                                 join u in context.Users
                                 on cs.UserId equals u.Id

                                 select new RentalDetailDto
                                 {
                                     Id = r.Id,
                                     CarName = c.Name,
                                     BrandName = b.Name,
                                     CustomerName = u.FirstName+" "+ u.LastName,
                                     RentDate=r.RentDate,
                                     ReturnDate=r.ReturnDate
                                 };


                    return result.ToList();
                }
            }
        }
    }
}
