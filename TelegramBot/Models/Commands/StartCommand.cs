using Telegram.Bot.Types;

namespace TelegramBot.Models.Commands
{
    public class StartCommand : Command
    {
        public override string Name { get; } = "/start";

        public async override void Execute(Message message)
        {
            string text = "Hi there! I am bot a .NET 5 Web Hook based bot!";

            await Bot.Client.SendTextMessageAsync(message.Chat.Id, text);
        }
    }
}
