using Microsoft.Extensions.Configuration;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;
namespace CreatingTelegramBot
{
    internal class Program
    {
        private static TelegramBotClient BotClient { get; set; }
        static async Task Main(string[] args)
        {
            SettingTelegramBot();
            var whoIsBot = await BotClient.GetMe();
            Console.WriteLine($" Bot is {whoIsBot.FirstName}, {whoIsBot.Username}, {whoIsBot.LastName}");
            var receiver = new ReceiverOptions
            {
                AllowedUpdates = [UpdateType.Message],
                DropPendingUpdates = true
            };
            var handler = new UpdateHandler();
            handler.OnHandleUpdateStarted += (message) => Console.WriteLine("Началась обработка сообщения '{0}'",message);
            handler.OnHandleUpdateCompleted += (message) => Console.WriteLine("Закончилась обработка сообщения '{0}'", message);
            BotClient.StartReceiving(updateHandler: handler, receiverOptions: receiver);
            await Task.Delay(-1);
        }
        private static void SettingTelegramBot()
        {
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            BotSettings botSettings = config.GetSection("BotConfig").Get<BotSettings>();

            botSettings.TokenBot = config["BotConfig:BotToken"];

            string? token = botSettings.TokenBot;
            using var cts = new CancellationTokenSource();

            if (!String.IsNullOrEmpty(token))
            {
                BotClient = new TelegramBotClient(token, cancellationToken: cts.Token);
            }
        }
    }
}
