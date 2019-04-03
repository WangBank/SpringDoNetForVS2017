using IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTest.Controllers
{
    public class SpringDoNetTestController : Controller
    {

        public ITest itest { get; set; }
        // GET: SpringDoNetTest
        public ActionResult Index()
        {
           var name =  itest.GetName();
            return View(name);
        }
    }
}