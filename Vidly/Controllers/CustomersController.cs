using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customer = new List<Customer>
            {
              new Customer {Name="Jyotirmoy", Id=1},
              new Customer {Name="Maschatak", Id=2}
            };

            var viewModel = new RandomMovieViewModel
            {

                Customers = customer
            };

            return View(viewModel);

        }

        public ActionResult Details(int Id)
        {
            if (Id == 1)
            {
                    var customer1 = new List<Customer>
                {
                  new Customer {Name="Jyotirmoy", Id=1},
                  
                };

                var viewModel = new RandomMovieViewModel
                {

                    Customers = customer1
                };
                return View(viewModel);
            }
            else if (Id == 2)
            {
                var customer2 = new List<Customer>
                {
                  new Customer {Name="Maschatak", Id=2},

                };

                var viewModel = new RandomMovieViewModel
                {

                    Customers = customer2
                };
                return View(viewModel);
            }

            return HttpNotFound();   
        }
    }
}