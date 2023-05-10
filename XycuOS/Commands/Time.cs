namespace XycuOS;

public class Time : Command
{
    public static string name = "time";
    public static string description = "Displays current system time";

    public override void Run()
    {
        DateTime localDateTime = DateTime.Now;
        /*
            hh - hours
            mm - minutes
            ss - seconds
            ff - milliseconds
        */
        string time = localDateTime.ToString("hh:mm:ss.ff");

        Console.WriteLine(time);
    }

    public Time() : base(name, description) {}
}