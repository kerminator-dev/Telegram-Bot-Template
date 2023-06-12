namespace Telegram.Bot.Template.Handlers
{
    public interface IHandler<TModel>
    {
        void Handle(TModel model);
    }
}
