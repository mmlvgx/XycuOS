namespace XycuOS;

public class Commands
{
    public static Type CommandType = typeof(Command);
    public static Type[] TypesList = CommandType.Assembly.GetTypes();
    public static IEnumerable<Type> SubclassesEnumerable =
        TypesList.Where(type => type.IsSubclassOf(CommandType));
    public static IEnumerable<Command> CommandsEnumerable =
        SubclassesEnumerable.Select(type => (Command?)Activator.CreateInstance(type)).Cast<Command>();

    public static List<Command> CommandsList = CommandsEnumerable.ToList();
    public static Dictionary<string, Command> CommandsDictionary =
        CommandsList.ToDictionary(command => command.Name, command => command);
}