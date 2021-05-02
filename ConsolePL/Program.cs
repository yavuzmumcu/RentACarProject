using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFreamwork;
using Entities.Concrete;
using System;

namespace ConsolePL
{
    class Program
    {
        
        static void Main(string[] args)
        {

            ICarDal carDal = new InMemoryCarDal();

            CarManager carManager = new CarManager(carDal);
            

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear);
            } ;
        }
    }
}
