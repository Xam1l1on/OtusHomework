namespace WorkWithFile
{
    public class FileManager
    {
        private readonly string[] _directories = { @"C:\Otus\TestDir1", @"C:\Otus\TestDir2" };
        private readonly int _fileCount = 10;

        public void CreateDirectories()
        {
            foreach (var dir in _directories)
            {
                DirectoryInfo directory = new DirectoryInfo(dir);
                if (!directory.Exists)
                {
                    directory.Create();
                    Console.WriteLine($"Директория создана: {dir}");
                }
                else
                {
                    Console.WriteLine($"Директория уже существует: {dir}");
                }
            }
        }

        public void CreateFiles()
        {
            foreach (var dir in _directories)
            {
                for (int i = 1; i <= _fileCount; i++)
                {
                    string filePath = Path.Combine(dir, $"File{i}.txt");
                    if (!File.Exists(filePath))
                    {
                        try
                        {
                            File.WriteAllText(filePath, $"File{i}", System.Text.Encoding.UTF8);
                            Console.WriteLine($"Файл создан: {filePath}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ошибка создания файла {filePath}: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Файл уже существует: {filePath}");
                    }
                }
            }
        }

        public string[] GetAllFiles()
        {
            var files = new System.Collections.Generic.List<string>();
            foreach (var dir in _directories)
            {
                if (Directory.Exists(dir))
                {
                    files.AddRange(Directory.GetFiles(dir, "*.txt"));
                }
            }
            return files.ToArray();
        }
    }
}
