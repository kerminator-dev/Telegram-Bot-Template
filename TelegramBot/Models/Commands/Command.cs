using Telegram.Bot.Types;

namespace TelegramBot.Models.Commands
{
    /// <summary>
    /// Parent class that is subsequently implemented by children command classes
    /// </summary>
    public abstract class Command
    {
        /// <summary>
        /// Command name
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Execute command after Contains() validation
        /// </summary>
        /// <param name="message">client message</param>
        public abstract void Execute(Message message);

        /// <summary>
        /// Is the message related to the command
        /// </summary>
        /// <param name="message">Client message</param>
        /// <returns></returns>
        public virtual bool Contains(Message message)
        {
            if (message == null || message.Text == null) 
                return false;
            return message.Text.ToLower() == Name;
        }
    }
}
