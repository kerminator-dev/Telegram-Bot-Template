using Telegram.Bot.Types.Enums;

namespace Telegram.Bot.Template.Services
{
    public class TelegramBotClientService : ITelegramMessagingService
    {
        private readonly TelegramBotClient _client;

        public TelegramBotClientService(string token)
        {
            _client = new TelegramBotClient(token);
        }

        public async Task SendTextMessageAsync(long chatId, string text, ParseMode parseMode = ParseMode.Markdown)
        {
            await _client.SendTextMessageAsync(chatId, text, parseMode: parseMode);
        }
    }
}
