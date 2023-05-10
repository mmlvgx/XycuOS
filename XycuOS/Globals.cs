namespace XycuOS;

public class Globals
{
    public static List<Command> commands = new()
    {
        new Help(),
        new Time(),
        new Date(),
    };
}