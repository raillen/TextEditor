using System;

namespace TextEditor
{
    public static class Menu
    {
        public static string Option { get; private set; }
        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option? ");

            Console.Write(
                "1 - Open File\n" +
                "2 - Edit a file\n" +
                "0 - Exit\n" +
                "Your choose: "
                );

            Option = Console.ReadLine();
        }

    }
}
