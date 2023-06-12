using Telegram.Bot.Template.Commands;
using Telegram.Bot.Template.Extensions;
using Telegram.Bot.Template.Handlers.Commands;
using Telegram.Bot.Template.Handlers.Updates;

var builder = WebApplication.CreateBuilder(args);

// Telegram Bot-������
builder.Services.AddTelegramBotClient(builder.Configuration);

// �������� �������:
builder.Services.AddSingleton<ICommand, StartCommand>();

// ����������� ���������� �����������
builder.Services.AddSingleton<IMessageHandler, DefaultMessageHandler>();
builder.Services.AddSingleton<IUpdateHandler, DefaultUpdateHandler>();

// ��� ��� ������������
builder.Services.AddControllers().AddNewtonsoftJson();


var app = builder.Build();
app.MapControllers();
app.Run();
