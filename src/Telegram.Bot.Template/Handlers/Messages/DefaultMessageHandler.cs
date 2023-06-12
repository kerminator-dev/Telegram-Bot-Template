using Telegram.Bot.Template.Commands;
using Telegram.Bot.Types;

namespace Telegram.Bot.Template.Handlers.Commands
{
    public class DefaultMessageHandler : IMessageHandler
    {
        private readonly IEnumerable<ICommand> _commands;

        public DefaultMessageHandler(IEnumerable<ICommand> commands)
        {
            _commands = commands;
        }

        public void Handle(Message message)
        {
            if (message == null || message.Text == null)
                return;

            foreach (var command in _commands)
            {
                if (command.CanExecute(message.Text))
                {
                    command.ExecuteAsync(message);
                    break;
                }
            }
        }
    }
}
