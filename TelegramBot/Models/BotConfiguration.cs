namespace TelegramBot.Models
{
    public static class BotConfiguration
    {
        public static class Hook
        {
            public static bool Enabled { get; } = true;
            public static string Url { get; } = @"";
        }
        public static string Token { get; }  = "";
    }
}
