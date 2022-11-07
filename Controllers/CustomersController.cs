using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.ViewModel;

namespace Vidly.Models
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Customer()
        {
            var customers = new List<CustomerModel>
            {
                new CustomerModel { firstName = "Yohan", lastName = "Garcia", Id = 1},
                new CustomerModel { firstName = "Claudia", lastName = "Ananaias", Id = 2},
                new CustomerModel { firstName = "Erika", lastName = "Garcia", Id = 3},
                new CustomerModel { firstName = "Adam", lastName = "Garcia", Id = 4},
                new CustomerModel { firstName = "Sky", lastName = "", Id = 5}
            };
            var customersModel = new CustomersViewModel
            {
                Customer = customers
            };
            
            return View(customersModel);
        }
    }
}