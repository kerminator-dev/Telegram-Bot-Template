using Telegram.Bot.Template.Services;

namespace Telegram.Bot.Template.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTelegramBotClient(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration is null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            // Попытка получения токена Бота из appsettings.json
            var token = configuration.GetSection("Bot")?.GetValue<string>("Token");
            if (string.IsNullOrWhiteSpace(token))
            {
                throw new ArgumentException("TelegramBot.Token configuration value is required.", nameof(configuration));
            }

            // Регистрация Бот-клиента
            services.AddSingleton<ITelegramMessagingService, TelegramBotClientService>(p =>
            {
                return new TelegramBotClientService(token);
            });

            return services;
        }
    }
}
