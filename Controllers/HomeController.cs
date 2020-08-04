using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessPro.Models;

namespace BusinessPro.Controllers
{
    public class HomeController : Controller
    {
        private IPhoneCallerRepository repository;
        public HomeController(IPhoneCallerRepository repo) => repository = repo;

        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PhoneCaller phoneCaller)
        {
            repository.AddPhoneCaller(phoneCaller);
            return RedirectToAction("Index");
        }
    }
}
