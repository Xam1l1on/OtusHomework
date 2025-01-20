using Microsoft.Extensions.Configuration;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;
namespace CreatingTelegramBot
{
    internal class Program
    {
        private static TelegramBotClient BotClient { get; set; }
        private static char exitChar = 'A';
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
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            var handler = new UpdateHandler();
            handler.OnHandleUpdateStarted += (message) => Console.WriteLine("Началась обработка сообщения '{0}'",message);
            handler.OnHandleUpdateCompleted += (message) => Console.WriteLine("Закончилась обработка сообщения '{0}'", message);
            BotClient.StartReceiving(updateHandler: handler, receiverOptions: receiver);
            Console.WriteLine("Нажмите клавишу A для выхода");
            while (!cancelTokenSource.IsCancellationRequested)
            {
                if (Console.ReadKey(true).Key != ConsoleKey.A)
                {
                    Console.WriteLine(whoIsBot.FirstName);
                }
                else
                {
                    cancelTokenSource.Cancel();
                    //break;
                }
            }
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
