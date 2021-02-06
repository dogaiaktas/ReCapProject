using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _Cars;
        public InMemoryCarDal()
        {
            _Cars = new List<Car>
            {
                new Car {CarId=1, BrandId=1,ColorId=1, ModelYear= 2012, DailyPrice= 205, Description="5 seater" },
                new Car {CarId=2, BrandId=2,ColorId=2, ModelYear= 2009, DailyPrice= 125, Description="7 seater" },
                new Car {CarId=3, BrandId=2,ColorId=1, ModelYear= 2019, DailyPrice= 400, Description="Automatic Transmission" },
                new Car {CarId=4, BrandId=3,ColorId=3, ModelYear= 2005, DailyPrice= 85, Description="Air Conditioned" },
                new Car {CarId=5, BrandId=4,ColorId=4, ModelYear= 2021, DailyPrice= 600, Description="Electrical" },

            };
       
        }

        public void Add(Car car)
        {
            _Cars.Add(car);
        }

       

        public void Delete(Car car)
        {
            Car CarToDelete = _Cars.SingleOrDefault(c => c.CarId == car.CarId);
            _Cars.Remove(CarToDelete);
        }

      

        public List<Car> GetAll()
        {
            return _Cars;
        }

        public List<Car > GetById()
        {
            return _Cars;
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _Cars.SingleOrDefault(c => c.CarId == car.CarId);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
            
        }

       
    }
}
