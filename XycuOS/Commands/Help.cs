namespace XycuOS;

public class Help : Command
{
    public static string name = "help";
    public static string description =
        "Displays information about all available commands";

    public override void Run()
    {
        foreach (Command command in Globals.commands)
        {
            string information =
                $"{command.Name}\n\t{command.Description}";

            Console.WriteLine(information);
        }
    }

    public Help() : base(name, description) {}
}