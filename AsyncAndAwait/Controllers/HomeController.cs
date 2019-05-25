using AsyncAndAwait.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AsyncAndAwait.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet]
        public ActionResult Index()
        {
            Stopwatch watch= new Stopwatch();
            watch.Start();
            DemoMethods methods = new DemoMethods();
            var content = methods.Content();
            var count = methods.Count();
            var name = methods.Name();
            watch.Stop();
            ViewBag.WatchMilliseconds = watch.ElapsedMilliseconds;
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> IndexAsync()
        {
            Stopwatch watch = new Stopwatch();
            DemoMethods methods = new DemoMethods();
            watch.Start();
            var contentTask = methods.ContentAsync();
            var countTask = methods.CountAsync();
            var nameTask = methods.NameAsync();

            var content = await contentTask;
            var count = await countTask;
            var name = await nameTask;
            watch.Stop();
            ViewBag.WatchMilliseconds = watch.ElapsedMilliseconds;
            return View("Index");
        }
    }
}