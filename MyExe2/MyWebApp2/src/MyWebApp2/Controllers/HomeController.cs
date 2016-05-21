using System;

namespace MyWebApp2.Controllers
{
    using Microsoft.AspNet.Mvc;

    public class HomeController : Controller
    {
        [HttpGet()]
        public string Index() => "Hello from MVC!";
    }
}
