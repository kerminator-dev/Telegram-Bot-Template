using Telegram.Bot.Template.Commands;
using Telegram.Bot.Template.Extensions;
using Telegram.Bot.Template.Handlers.Commands;
using Telegram.Bot.Template.Handlers.Updates;

var builder = WebApplication.CreateBuilder(args);

// Telegram Bot-клиент
builder.Services.AddTelegramBotClient(builder.Configuration);

// Основные команды:
builder.Services.AddSingleton<ICommand, StartCommand>();

// Обработчики приходящих уведомлений
builder.Services.AddSingleton<IMessageHandler, DefaultMessageHandler>();
builder.Services.AddSingleton<IUpdateHandler, DefaultUpdateHandler>();

// Тут без комментариев
builder.Services.AddControllers().AddNewtonsoftJson();


var app = builder.Build();
app.MapControllers();
app.Run();
