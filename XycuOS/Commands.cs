namespace XycuOS;

public class Commands
{
    public static List<Command> commands = new()
    {
        new Help(),
        new Time(),
        new Date(),
    };
}