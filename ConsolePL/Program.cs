using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFreamwork;
using Entities.Concrete;
using System;

namespace ConsolePL
{
    class Program
    {
        
        static void Main(string[] args)
        {

            ICarDal carDal =new EfCarDal();
            CarManager carManager = new CarManager(carDal);
            carManager.Add(new Car { });
        }
    }
}
