using Telegram.Bot.Template.Services;
using Telegram.Bot.Types;

namespace Telegram.Bot.Template.Commands
{
    public class StartCommand : CommandBase
    {

        public StartCommand(ITelegramMessagingService client) : base(client)
        {

        }

        public override bool CanExecute(string actualCommand)
        {
            return Equals(actualCommand, expectedCommand: "/start");
        }

        public override async Task ExecuteAsync(Message receivedMessage)
        {
            var chatId = receivedMessage.Chat.Id;

            var message = "Hello, welcome to my bot!";

            await _client.SendTextMessageAsync(chatId, message);
        }
    }
}
