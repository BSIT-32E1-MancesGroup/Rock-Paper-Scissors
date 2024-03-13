using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Rock_Paper.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public JsonResult Play(string choice)
        {
            string[] choices = { "rock", "paper", "scissors" };
            var random = new Random();
            var serverChoice = choices[random.Next(0, 3)];
            var result = "Tie";

            if (choice == "rock" && serverChoice == "scissors" ||
                choice == "paper" && serverChoice == "rock" ||
                choice == "scissors" && serverChoice == "paper")
            {
                result = "You win!";
            }
            else if (serverChoice == "rock" && choice == "scissors" ||
                    serverChoice == "paper" && choice == "rock" ||
                    serverChoice == "scissors" && choice == "paper")
            {
                result = "Server wins!";
            }

            var jsonResult = new
            {
                userChoice = choice,
                serverChoice = serverChoice,
                message = result
            };

            return Json(jsonResult);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
