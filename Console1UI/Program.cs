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
            ICarService _carService = new CarManager(new EfCarDal());
            //GetAll();
            //Add();
            //GetCarsByBrandId();
            //GetCarsByColorId();

        static void Add()
        {
          
                Car car = new Car
                {
                    BrandId = 7,
                    ColorId = 9,
                    DailyPrice = 0,
                    Description = "Yeni Araç",
                    ModelYear = 2015,
                    CarName = "BMV"
                };
                _carService.Add(car); 
        }
        static void GetCarsByBrandId()
        {
            List<CarDetailDto> cars = _carService.GetCarsByBrandId(4);
            foreach (var car in cars)
            {
                Console.WriteLine(String.Format($"Id : {car.Id}, Name : {car.Name}, BrandId : {car.ColorId}"));
            }
        }
        static void GetCarsByColorId()
        {
            List<CarDetailDto> cars = _carService.GetCarsByColorId(8);
            foreach (var car in cars)
            {
                Console.WriteLine(String.Format($"Id : {car.Id}, Name : {car.Name}, ColorId : {car.ColorId}"));

            }
        }
        static void GetAll()
        {
            foreach (Car car in _carService.GetAll())
            {
                Console.WriteLine(String.Format($"Id : {car.Id}, Name : {car.CarName}"));

            }

        }
    }
}
