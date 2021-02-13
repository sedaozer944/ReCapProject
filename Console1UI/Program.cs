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
            //CarManagerTest();
            //CustomerManagerTest();
            //RentalManagerTest();
            //UserManagerTest();

        }

        private static void UserManagerTest()
        {
            IUserService _userManager = new UserManager(new EfUserDal());

            var result = _userManager.GetAll();

            if (result.Success == true)
            {
                foreach (var user in _userManager.GetAll().Data)
                {
                    Console.WriteLine(user.FirstName + " - " + user.LastName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalManagerTest()
        {
            IRentalService _rentalManager = new RentalManager(new EfRentalDal());

            var result = _rentalManager.GetAll();

            if (result.Success == true)
            {
                foreach (var rental in _rentalManager.GetAll().Data)
                {
                    Console.WriteLine(rental.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerManagerTest()
        {
            ICustomerService _customerManager = new CustomerManager(new EfCustomerDal());

            var result = _customerManager.GetAll();

            if (result.Success == true)
            {
                foreach (var customer in _customerManager.GetAll().Data)
                {
                    Console.WriteLine(customer.CompanyName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarManagerTest()
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
