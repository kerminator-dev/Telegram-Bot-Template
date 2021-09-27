using Telegram.Bot.Types;

namespace TelegramBot.Models
{
    public class MessageHandler
    {
        public static void Invoke(Update update)
        {
            if (update == null || update.Message == null)
                return;

            OnMessageReceived(update.Message);
        }

        /// <summary>
        /// Handle received message
        /// </summary>
        /// <param name="message"></param>
        private static void OnMessageReceived(Message message)
        {
            if (message == null || message.Text.Trim() == string.Empty)
                return;

            foreach (var command in Bot.Commands)
            {
                if (command.Contains(message))
                {
                    command.Execute(message);
                    break;
                }
            }
        }
    }
}
