namespace XycuOS;

public class HelpCommand : Command
{
    public static string name = "Help";
    public static string description =
        "Displays information about all available commands";

    public override void Run()
    {
        foreach (Command command in Commands.CommandsList)
        {
            string information =
                $"・ {command.Name}\t{command.Description}";

            Console.WriteLine(information);
        }
    }

    public HelpCommand() : base(name, description) {}
}