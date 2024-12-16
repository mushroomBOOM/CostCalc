using Microsoft.AspNetCore.Mvc;

namespace CostCalcAPI.Controllers
{
    [ApiController] // Это превращает контроллер в API-контроллер
    [Route("/")]   // Обрабатываем запросы на / (например, http://localhost:8080/)
    public class HomeController : ControllerBase // Используйте ControllerBase для API
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Hello from HomeController!");
        }
    }
}
