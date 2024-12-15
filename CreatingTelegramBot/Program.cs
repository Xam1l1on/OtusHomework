using Microsoft.Extensions.Configuration;
using Telegram.Bot;
using Telegram.Bot.Polling;
namespace CreatingTelegramBot
{
    internal class Program
    {
        private static TelegramBotClient BotClient { get; set; }
        static async Task Main(string[] args)
        {

            SettingTelegramBot();
            var me = await BotClient.GetMe();
            Console.WriteLine(me);
        }
        private static void SettingTelegramBot()
        {
            //BotSettings botSettings = new BotSettings();
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            BotSettings botSettings = config.GetSection("AppSettings").Get<BotSettings>();

            botSettings.TokenBot = config["AppSettings:AppToken"];

            string? token = botSettings.TokenBot;
            using var cts = new CancellationTokenSource();

            if (!String.IsNullOrEmpty(token))
            {
                BotClient = new TelegramBotClient(token, cancellationToken: cts.Token);
            }
        }
    }
}
