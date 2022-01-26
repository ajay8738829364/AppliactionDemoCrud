using ApplicationDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationDemo.Controllers
{
    public class DemoController : Controller
    {
        public IDemo idemo { get; }
        public DemoController(IDemo _demo)
        {
            idemo = _demo;
        }
        public IActionResult Index()
        {
            var emp = idemo.GetDemo();
            return View(emp);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Demo demo)
        {
            idemo.AddDemo(demo);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var q = idemo.Delete(id);
            if(q)
            {
                ViewBag.message = "Record Delete Successfull";
            }
            else
            {
                ViewBag.message = "Record Not  Deleted ";
            }
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int id)
        {
            var q = idemo.EditById(id);
            return View(q);
        }
        [HttpPost]
        public IActionResult Update(Demo demo)
        {
            idemo.UpdateDemo(demo);
            return RedirectToAction("Index");
        }
    }
}
