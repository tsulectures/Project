using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTOs.Person;
using BLL.Interfaces;
using DAL.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonalData.Helper;
using PersonalData.Models;
using Service.Contracts;

namespace PersonalData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersonOperation _personOperation;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public HomeController(
            ILogger<HomeController> logger, 
            IPersonOperation personOperation, 
            IWebHostEnvironment hostingEnvironment)
        {
            _logger = logger;
            _personOperation = personOperation;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            PersonListVM model = new PersonListVM()
            {
                Persons = _personOperation.GetAll()
            };
            return View(model);
        }

        public IActionResult Create()
        {
            var model = GetCreatePersonModel(new PersonCUDTO());
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(PersonCUVM model)
        {
            if(!ModelState.IsValid)
            {
                return View(GetCreatePersonModel(model.Person));
            }
            model.Person.Picture = FileUploader.UploadFile(model.Person.File, _hostingEnvironment);
            _personOperation.CreatePerson(model.Person);
            return RedirectToAction(nameof(Index));
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private PersonCUVM GetCreatePersonModel(PersonCUDTO person)
        {
            PersonCUVM model = new PersonCUVM()
            {
                Components = _personOperation.GetPersonFormComponents(),
                Person = person
            };
            return model;
        }
    }
}
