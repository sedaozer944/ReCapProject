using System;
using Entities1;
using DataAccess;
using Business1;
using Business1.Concrete;
using DataAccess.Abstract;
using Entities1.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using Business1.Abstract;
using Entities1.DTOs;
using System.Collections.Generic;

namespace Console1UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            ICarService _carManager = new CarManager(new EfCarDal());

            var result = _carManager.GetCarDetailDto();

            if (result.Success == true)
            {
                foreach (var car in _carManager.GetCarDetailDto().Data)
                 {
                    Console.WriteLine(car.Name + "/" + car.BrandName);
                 }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

          
            
        }
       
    }
}
