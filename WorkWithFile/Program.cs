using System;
using System.Threading.Tasks;
namespace WorkWithFile
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Запуск программы...");

            FileManager fileManager = new FileManager();
            fileManager.CreateDirectories();
            fileManager.CreateFiles();

            string[] files = fileManager.GetAllFiles();

            FileProcess fileProcess = new FileProcess();
            await fileProcess.AppendDateToFilesAsync(files);
            await fileProcess.ReadFilesAsync(files);

            Console.WriteLine("✅ Работа завершена.");
        }
    }
}
