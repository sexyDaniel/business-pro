using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessPro.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BusinessPro.Controllers
{
    public class AdminController : Controller
    {
        //private IPhoneCallerRepository repository;
        //public AdminController(IPhoneCallerRepository repo) => repository = repo;

        //public ViewResult Index()
        //{
        //    return View(repository.phoneCallers);
        //}

        //public ViewResult Edit(int Id)
        //{
        //    return View(repository.phoneCallers.Values.FirstOrDefault(p => p.Id == Id));
        //}

        //[HttpPost]
        //public IActionResult Edit(PhoneCaller phoneCaller)
        //{
        //    repository.AddPhoneCaller(phoneCaller);
        //    return RedirectToAction("Index");
        //}

        //public IActionResult Delete(int Id)
        //{
        //    repository.DeletePhoneCaller(Id);
        //    return RedirectToAction("Index");
        //}
    }
}
