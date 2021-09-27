using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;
using TelegramBot.Models;

namespace TelegramBot.Controllers
{
    [Route(@"api/message/update")] // webhook url api
    public class MessageController : Controller
    {

        // POST api/values
        [HttpPost]
        public OkResult Post([FromBody] Update update)
        {
            if (update == null) return Ok();

            MessageHandler.Invoke(update);

            return Ok();
        }
    }
}
