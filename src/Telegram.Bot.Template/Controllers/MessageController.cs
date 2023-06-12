using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Template.Handlers.Updates;
using Telegram.Bot.Types;

namespace Telegram.Bot.Template.Controllers
{
    [ApiController]
    [Route("/api/Message/Update")]
    public class MessageController : ControllerBase
    {
        private readonly IUpdateHandler _updateHandler;

        public MessageController(IUpdateHandler updateHandler)
        {
            _updateHandler = updateHandler;
        }

        [HttpPost]
        public OkResult Post([FromBody] Update update)
        {
            if (update == null) 
                return Ok();

            try
            {
                _updateHandler.Handle(update);
            }
            catch (Exception)
            {
                return Ok();
            }
                
            return Ok();
        }

        [HttpGet]
        public string Get()
        {
            return "Telegram bot was started";
        }
    }
}
