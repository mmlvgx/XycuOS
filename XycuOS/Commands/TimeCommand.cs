namespace XycuOS;

public class TimeCommand : Command
{
    public static string name = "Time";
    public static string description = "Displays current system time";

    public override void Run()
    {
        DateTime localDateTime = DateTime.Now;

        // hh - hours
        // mm - minutes
        // ss - seconds
        // ff - milliseconds
        string time = localDateTime.ToString("hh:mm:ss.ff");

        Console.WriteLine(time);
    }

    public TimeCommand() : base(name, description) {}
}