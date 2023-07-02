using Microsoft.AspNetCore.Mvc;

namespace RiddleSuggestions.Controllers
{
    public class RiddleSuggestionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
