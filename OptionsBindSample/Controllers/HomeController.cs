using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace OptionsBindSample.Controllers
{
    public class HomeController : Controller
    {
        //private readonly Class _class;

        //public HomeController(IOptions<Class> classAddress)
        //{
        //    _class = classAddress.Value;
        //}

        public IActionResult Index()
        {
            return View();
        }
    }
}