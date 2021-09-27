using Microsoft.AspNetCore.Mvc;

namespace TelegramBot.Controllers
{
    [Route(@"Index")]
    public class HomeController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Hi there! This is Telegram Bot based on .NET 5!";
        }
    }
}
