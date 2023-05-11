namespace XycuOS;

public class ClearCommand : Command
{
    public static string name = "Clear";
    public static string description = "Clears the console buffer";

    public override void Run()
    {
        Console.Clear();
    }

    public ClearCommand() : base(name, description) {}
}