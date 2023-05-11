namespace XycuOS;

public class DateCommand : Command
{
    public static string name = "Date";
    public static string description = "Displays current system date";

    public override void Run()
    {
        DateTime localDateTime = DateTime.Now;
        /*
            MM   - month
            dd   - day
            yyyy - year
        */
        string date = localDateTime.ToString("MM/dd/yyyy");

        Console.WriteLine(date);
    }

    public DateCommand() : base(name, description) {}
}