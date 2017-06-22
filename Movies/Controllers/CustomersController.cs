﻿using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Movies.ViewModels;
using System.Net;
using System.Runtime.Caching;

namespace Movies.Controllers
{
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Customers
        public ViewResult Index()
        {


            //caching example
            if (MemoryCache.Default["MoviesGenre"] == null)
            {
                MemoryCache.Default["MoviesGenre"] = _context.MembershipType.ToList();
            }
            var genres = MemoryCache.Default["MoviesGenre"] as IEnumerable<MoviesGenre>;

            //var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            if (User.IsInRole(RoleName.CanManageMovies))
            {
                return View();
            }

            return View("ReadOnlyList");


            
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();
           return View(customer);
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if(customer == null)
            {
                return HttpNotFound();
            }

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipType.ToList()
            };
            return View("CustomerForm", viewModel);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipType.ToList();


            //A new Class was create so that we can pass different objects as parameters
            var viewModel = new CustomerFormViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm", viewModel);
        }


        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if(!ModelState.IsValid) //Validation
            {

                
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipType.ToList()
                };
               
                return View("CustomerForm", viewModel);
            }
            
            if(customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                
                customerInDb.Name = customer.Name;
                customerInDb.Birthday = customer.Birthday;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;

            }
            
            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

       
        
    }
}