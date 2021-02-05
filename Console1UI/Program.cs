using Business1.Concrete;
using DataAccess1.Concrete.InMemory;
using DataAccess1.Abstract;
using System;
using Entities1.Concrete;

namespace Console1UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal(new Car()));
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandId);
            }

        }
    }
}
