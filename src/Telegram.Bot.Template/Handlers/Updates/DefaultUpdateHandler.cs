using Telegram.Bot.Template.Handlers.Commands;
using Telegram.Bot.Types;

namespace Telegram.Bot.Template.Handlers.Updates
{
    public class DefaultUpdateHandler : IUpdateHandler
    {
        private readonly IMessageHandler _messageHandler;

        public DefaultUpdateHandler(IMessageHandler messageHandler)
        {
            _messageHandler = messageHandler;
        }

        public void Handle(Update update)
        {
            if (update == null)
                return;

            if (update.Message != null)
            {
                _messageHandler.Handle(update.Message);
            }
        }
    }
}
