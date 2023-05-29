using TextEditor;

Menu.ShowMenu();

short option = short.Parse(Menu.Option);

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
