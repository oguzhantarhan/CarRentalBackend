using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalContext context=new CarRentalContext())
            {
                {
                    var result = from car in context.Cars
                                 join b in context.Brands
                                 on car.BrandId equals b.Id
                                 join c in context.Colors
                                 on car.ColorId equals c.Id
                                 select new CarDetailDto
                                  {
                                      Id=c.Id,
                                      CarName = car.Name,
                                      BrandName = b.Name,
                                      DailyPrice = car.DailyPrice,
                                      ColorName=c.Name
                                  };


                    return result.ToList();
                }
            }
        }
    }
}
