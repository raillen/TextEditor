using TextEditor;

Menu.ShowMenu();

var option = byte.Parse(Console.ReadLine());

switch (option)
{
    case 0:
        Environment.Exit(0);
        break;
    case 1:
        FileEditor.OpenFile();
        break;
    case 2:
        FileEditor.EditFile();
        break;
    default:
        Menu.ShowMenu();
        break;
}
