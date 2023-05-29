using System.Text;
using System.IO;

namespace TextEditor
{
    public static class FileEditor
    {
        static StringBuilder text = new StringBuilder();
        public static void OpenFile()
        {
            Console.Clear();
            Console.Write("File path: ");

            var path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                Console.WriteLine(file.ReadToEnd());
            }
        }

        public static void EditFile()
        {

            Console.WriteLine("Write your text: (ESC to exit)");

            do
            {
                string line = Console.ReadLine();
                text.AppendLine(line);
                if (Console.ReadKey().Key == ConsoleKey.End) break;
            }
            while (true);

            SaveFile(text.ToString());
        }
        public static void SaveFile(string text)
        {
            Console.Clear();
            Console.Write("Path to save: ");
            var path = Console.ReadLine();

            //using abre e fecha o arquivo, para não esquecer.
            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.Write($"File {path} successfully saved!");
            Console.ReadKey();
        }
    }
}
