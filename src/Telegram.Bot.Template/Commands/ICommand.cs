using Telegram.Bot.Types;

namespace Telegram.Bot.Template.Commands
{
    public interface ICommand
    {
        public bool CanExecute(string str);
        public Task ExecuteAsync(Message message);
    }
}
