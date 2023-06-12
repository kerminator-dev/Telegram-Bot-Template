using Telegram.Bot.Types.Enums;

namespace Telegram.Bot.Template.Services
{
    public interface ITelegramMessagingService
    {
        Task SendTextMessageAsync(long chatId, string text, ParseMode parseMode = ParseMode.Markdown);
    }
}
