using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CreatingTelegramBot
{
    internal class UpdateHandler : IUpdateHandler
    {
        internal delegate void HandleUpdate(string message);
        internal event HandleUpdate? OnHandleUpdateStarted;
        internal event HandleUpdate? OnHandleUpdateCompleted;
        
        public Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, HandleErrorSource source, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            var message = update.Message?.Text;
            OnHandleUpdateStarted?.Invoke(message);
            if (update.Type == UpdateType.Message && update.Message?.Type == MessageType.Text)
            {
                await BotOnMessageReceived(botClient, update.Message);
            }
            OnHandleUpdateCompleted?.Invoke(message);
        }
        
        private async Task BotOnMessageReceived(ITelegramBotClient botClient, Message message)
        {
            await botClient.SendMessage(chatId: message.Chat.Id, text: $"Сообщение успешно принято");
        }
    }
}
