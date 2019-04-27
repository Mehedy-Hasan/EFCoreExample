using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseContext.DbContext;
using DeployeeTheme.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;

namespace DeployeeTheme.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Create()
        {
            List<SelectListItem>countryDataList=new List<SelectListItem>()
            {
                new SelectListItem(){Value="Banladesh",Text="Bangladesh"},
                new SelectListItem(){Value = "India",Text = "India"},
                new SelectListItem(){Value = "China",Text = "Chaina"},
                new SelectListItem(){Value = "Thailand",Text = "Thailand"}
            };
            List<SelectListItem>GenderDataList=new List<SelectListItem>()
            {
                new SelectListItem(){Value = "Male",Text = "Male"},
                new SelectListItem(){Value = "Female",Text = "Female"}
            };
            ViewBag.CountryList = countryDataList;
            ViewBag.GenderList = GenderDataList;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                CustomerDbContext db=new CustomerDbContext();
                db.Customers.Add(customer);
                bool isSaved=db.SaveChanges()>0;
                if (isSaved)
                {
                    return RedirectToAction("Details", customer);
                }
                
            }

            return View();
        }

        public IActionResult Details(Customer customer)
        {
            ViewBag.Title = "CustomerDetails";
            return View(customer);
        }
    }
}