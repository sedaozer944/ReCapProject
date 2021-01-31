using Business1.Concrete;
using DataAccess1.Concrete.InMemory;
using System;

namespace Console1UI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandId);
            }
        }
    }
}
