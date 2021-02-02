using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemory : ICarDal
    {
        List<Car> _cars;
        public InMemory()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,DailyPrice=150000,ModelYear=2005,ColorId=1,Description="Woksvagen Araba"},
                new Car{Id=2,BrandId=1,DailyPrice=200000,ModelYear=2010,ColorId=1,Description="Woksvagen Araba"},
                new Car{Id=3,BrandId=2,DailyPrice=250000,ModelYear=2020,ColorId=1,Description="Mercedes Araba"},
                new Car{Id=4,BrandId=2,DailyPrice=300000,ModelYear=2008,ColorId=2,Description="Mercedes Araba"},
                new Car{Id=5,BrandId=3,DailyPrice=250000,ModelYear=2000,ColorId=2,Description="BWM Araba"},
                new Car{Id=6,BrandId=3,DailyPrice=200000,ModelYear=2015,ColorId=3,Description="BWM Araba"}
            };
        }

        public void Add(Car car)
        {
            if (car != null && car.Id > 0)
            {
                _cars.Add(car);
            }
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            foreach (var c in _cars)
            {
                if (car.Id == c.Id)
                {
                    carToDelete = c;
                }

            }
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(car);


        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(Car car)
        {
            Car getCar = null;
            if (car.Id > 0 && car != null)
            {
                getCar = _cars.Find(x => x.Id == car.Id);
            }

            return getCar;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == c.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

    }
}
