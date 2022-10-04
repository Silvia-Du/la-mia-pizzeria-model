using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {

        public IActionResult Index()
        {
            return View("Home");
        }
        public IActionResult Pizze()
        {
            List<Pizza> pizzeList = new()
            {
                new Pizza("Margherita", "pomodoro, mozzarella", "/img/pizza1.png", 10.99F ),
                new Pizza("Marinara", "pomodoro, aglio rosmarino", "/img/pizza2.png", 7.99F),
                new Pizza("Lombarda", "pomodoro, mozzarella, carciofi, grana", "/img/pizza3.png", 11.99F),
                new Pizza("Pugliese", "pomodoro, mozzarella, capperi, aciughe", "/img/pizza4.png", 10.99F)

            };
            return View("Index", pizzeList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}