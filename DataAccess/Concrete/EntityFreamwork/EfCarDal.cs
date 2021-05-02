using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            Console.WriteLine("Eklendi");
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public void GetAll(Car entity)
        {
            throw new NotImplementedException();
        }

        public void GetById(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
