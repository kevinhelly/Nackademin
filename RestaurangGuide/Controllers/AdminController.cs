using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurangGuide.DB.Models;

namespace RestaurangGuide.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index(string username, string password)
        {
            Restaurant TestRestaurant;
            Rating[] testRatings;
            Order[] Orders;

            TestRestaurant = new Restaurant()
            {
                Address = "Test Adress",
                Capacity = 500,
                City = "Djurhamn",
                Commune = "Värmdö",
                Description = "En god pizzeria på en ö i ingenstans",
                Firstname = "Kevin",
                Lastname = "Helly",
                Id = 1,
                Image = null,
                NumberOfSeats = 250,
                RestaurantName = "Restaurang Någonstans",
                TotalGuests = 0,
                ZipCode = 13973,
                Ratings = {new Rating()
                {
                    DateCreated = DateTime.Now,
                    Id = 2,
                    Name = "Anon",
                    Rating1 = 3.5m,
                    RestaurangId = 1,
                    Review = "Hej"
                },
                new Rating()
                {
                    DateCreated = DateTime.Now.AddDays(-3),
                    Id = 1,
                    Name = "Mikael",
                    Rating1 = 3.7m,
                    RestaurangId = 1,
                    Review = "Hej"
                }}
            };

            //testRatings = new[]{
                

            //};

            //Orders = new[]{
            //    new Order()
            //    {
            //        Arrival = new DateTime(2014, 09, 06),
            //        DateCreated = DateTime.Now,
            //        Email = "kevinhelly.kh@gmail.com",
            //        Firstname = "Kevin",
            //        Lastname = "Helly",
            //        Id = 0,
            //        NumberOfGuests = 1,
            //        Phone = "0735016455",
            //        RestaurangId = 1
            //    },
            //    new Order()
            //    {
            //        Arrival = new DateTime(2014, 09, 06),
            //        DateCreated = DateTime.Now,
            //        Email = "kevinhelly.kh@gmail.com",
            //        Firstname = "Kevin",
            //        Lastname = "Helly",
            //        Id = 1,
            //        NumberOfGuests = 1,
            //        Phone = "0735016455",
            //        RestaurangId = 1
            //    }
            //};

            return View(TestRestaurant);
        }

        [HttpPost]
        public ActionResult Index(Restaurant restaurant)
        {
            return View(restaurant);
        }

    }
}
