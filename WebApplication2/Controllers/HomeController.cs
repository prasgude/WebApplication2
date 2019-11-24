using System.Collections.Generic;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public string Index1(string id, string name)
        {
            //return typeof(Controller).Assembly.GetName().Version.ToString();
            //return "Hello This is Suman";
            return "Id = " + id + "Name = " + name;
        }

        public string getDetails()
        {
            //return typeof(Controller).Assembly.GetName().Version.ToString();
            return "getDetails Invoked";
        }

        public ViewResult Index()
        {
           ViewData["CountryList"] = new List<string>()
            {
                "India",
                "UK",
                "USA",
                "Canada"
            };
            return View();
        }




    }
}