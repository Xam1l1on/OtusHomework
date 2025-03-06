using System.Text;

namespace WorkWithFile
{
    public class FileProcess
    {
        public async Task AppendDateToFilesAsync(string[] files)
        {
            foreach (var file in files)
            {
                try
                {
                    using StreamWriter writer = new StreamWriter(file, append: true, encoding: Encoding.UTF8);
                    await writer.WriteLineAsync($" - {DateTime.Now}");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine($"Нет прав на запись в файл: {file}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка записи в файл {file}: {ex.Message}");
                }
            }
        }

        public async Task ReadFilesAsync(string[] files)
        {
            foreach (var file in files)
            {
                try
                {
                    using StreamReader reader = new StreamReader(file, Encoding.UTF8);
                    string content = await reader.ReadToEndAsync();
                    Console.WriteLine($"{Path.GetFileName(file)}: {content.Trim()}");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine($"Файл не найден: {file}");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine($"Нет прав на чтение файла: {file}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка чтения файла {file}: {ex.Message}");
                }
            }
        }
    }
}
