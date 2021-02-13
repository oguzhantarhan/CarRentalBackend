using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
       
        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CarManager carManager = new CarManager(new EfCarDal());
            //Add(brandManager, colorManager);
            //GetBrands(brandManager);
            //CarAdd(carManager);
            //GetCarsDetail(carManager);
            
        }

        private static void GetCarsDetail(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(car.BrandName + " " + car.CarName + " Color:" +
                    car.ColorName + " DailyPrice:" + car.DailyPrice);
            }
        }

        private static void CarAdd(CarManager carManager)
        {
            carManager.Add(new Car
            {
                BrandId = 3,
                ColorId = 1,
                ModelYear = 2017,
                Name = "Clio",
                DailyPrice = 100,
                Description = "2017 CLIO 1.5 DCI ICON EDC"
            });
        }

        private static void GetBrands(BrandManager brandManager)
        {
            var brands = brandManager.GetAll();
            foreach (var brand in brands)
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void Add(BrandManager brandManager, ColorManager colorManager)
        {
            colorManager.Add(new Color { Name = "Red" });
            colorManager.Add(new Color { Name = "White" });
            colorManager.Add(new Color { Name = "Black" });
            colorManager.Add(new Color { Name = "Blue" });
            colorManager.Add(new Color { Name = "Gray" });
            colorManager.Add(new Color { Name = "Red" });

            brandManager.Add(new Brand { Name = "Opel" });
            brandManager.Add(new Brand { Name = "Fiat" });
            brandManager.Add(new Brand { Name = "Renault" });
            brandManager.Add(new Brand { Name = "Toyota" });
            brandManager.Add(new Brand { Name = "Peugeot" });
            brandManager.Add(new Brand { Name = "Volkswagen" });
            brandManager.Add(new Brand { Name = "Mercedes-Benz" });
            brandManager.Add(new Brand { Name = "Chevrolet" });
            brandManager.Add(new Brand { Name = "BMW" });
            brandManager.Add(new Brand { Name = "Honda" });
            brandManager.Add(new Brand { Name = "Nissan" });
            brandManager.Add(new Brand { Name = "Hyundai" });
            brandManager.Add(new Brand { Name = "Audi" });
            brandManager.Add(new Brand { Name = "Volvo" });
            brandManager.Add(new Brand { Name = "Mazda" });
            brandManager.Add(new Brand { Name = "Citroën" });
        }
    }
}
