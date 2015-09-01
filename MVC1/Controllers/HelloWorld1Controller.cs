using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class HelloWorld1Controller : Controller
    {
        //// GET: HelloWorld1
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // 
        // GET: /HelloWorld/ 

        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
        public string X1()
        {
            return "X1";
        }
        public string X2()
        {
            return "X2";
        }
        public string X3()
        {
            var cc =this.ControllerContext;
            var request =this.Request;
            var rd =this.RouteData;
            return "X3";
        }

        // names must match in any order, not case sensitive.

        public string Action(string name,  string id, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes + ", Id: "+ id);
        }
    }
}