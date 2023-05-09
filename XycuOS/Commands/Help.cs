namespace XycuOS;

public class Help : Command
{
    public override void Run()
    {
        Console.WriteLine("This is a help command");
    }

    public Help() : base("help") {}
}