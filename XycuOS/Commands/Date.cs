namespace XycuOS;

public class Date : Command
{
    public static string name = "date";
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

    public Date() : base(name, description) {}
}