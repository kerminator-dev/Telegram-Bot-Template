using System.Collections.Generic;
using Telegram.Bot;
using TelegramBot.Models.Commands;

namespace TelegramBot.Models
{
    public class Bot
    {
        private static Bot _Instanse = default;
        private readonly TelegramBotClient _Client;
        private readonly List<Command> _Commands;
        public static Bot Instance
        {
            get
            {
                if (_Instanse == null)
                {
                    _Instanse = new Bot();
                }
                return _Instanse;
            }
        }
        public static TelegramBotClient Client => Instance._Client;

        public static IReadOnlyList<Command> Commands
        {
            get => Instance._Commands.AsReadOnly();
        }

        private Bot()
        {
            _Commands = new List<Command>()
            {
                new StartCommand()
            };
            _Client = new TelegramBotClient(BotConfiguration.Token);

            if (BotConfiguration.Hook.Enabled)
                _Client.SetWebhookAsync(BotConfiguration.Hook.Url);
        }
    }
}
