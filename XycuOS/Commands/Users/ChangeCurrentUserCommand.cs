namespace XycuOS;

public class ChangeCurrentUserCommand : Command
{
    public static string name = "ChangeCurrentUser";
    public static string description = "Changes current user";

    public override void Run()
    {
        /*
            Get a User Name and User Pass from Standart Input Stream
        */
        Console.Write("User name: ");
        var userName = Console.ReadLine();

        Console.Write("User pass: ");
        var userPass = Console.ReadLine();

        Users.ChangeCurrentUser(userName, userPass);
    }

    public ChangeCurrentUserCommand() : base(name, description) {}
}