using Microsoft.AspNetCore.Mvc;

namespace ToDoList2.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}