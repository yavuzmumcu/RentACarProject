using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class EfCarDal : ICarDal
    {
        List<Car> _cars;

        public EfCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear=2021, DailyPrice=250, Description="Linea"},
                new Car{Id=2, BrandId=1, ColorId=2, ModelYear=2020, DailyPrice=500, Description="Egea"},
                new Car{Id=3, BrandId=2, ColorId=2, ModelYear=2019, DailyPrice=750, Description="Passat"},
                new Car{Id=4, BrandId=3, ColorId=3, ModelYear=2015, DailyPrice=1000, Description="BMW"},
            };
        }

        public void Add(Car entity)
        {
            _cars.Add(entity);
            Console.WriteLine(  "Araba Eklenedi");
        }

        public void Delete(Car entity)
        {
            Car carToDelete = _cars.SingleOrDefault(car => car.Id == entity.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(Car entity)
        {
           return _cars.Where(car => car.Id == entity.Id).ToList();
        }

        public void Update(Car entity)
        {
            Car carToUpdate = _cars.SingleOrDefault(car => car.Id == entity.Id);
            carToUpdate.ModelYear = entity.ModelYear;
            carToUpdate.ColorId = entity.ColorId;
            carToUpdate.BrandId = entity.BrandId;
            carToUpdate.DailyPrice = entity.DailyPrice;
            carToUpdate.Description = entity.Description;

        }
    }
}
