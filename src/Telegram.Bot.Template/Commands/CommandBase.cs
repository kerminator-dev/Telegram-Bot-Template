using Telegram.Bot.Template.Services;
using Telegram.Bot.Types;

namespace Telegram.Bot.Template.Commands
{
    public abstract class CommandBase : ICommand
    {
        protected readonly ITelegramMessagingService _client;

        protected CommandBase(ITelegramMessagingService client)
        {
            _client = client;
        }

        public abstract bool CanExecute(string str);

        public abstract Task ExecuteAsync(Message message);

        protected bool Equals(string actualCommand, string expectedCommand)
        {
            return actualCommand?.Equals(expectedCommand, StringComparison.OrdinalIgnoreCase) == true;
        }
    }
}
