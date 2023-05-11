namespace XycuOS;

public class CreateUserCommand : Command
{
    public static string name = "CreateUser";
    public static string description = "Creates a user";

    public override void Run()
    {
        /*
            Get a User Name and User Pass from Standart Input Stream
        */
        Console.Write("User name: ");
        var userName = Console.ReadLine();

        Console.Write("User pass: ");
        var userPass = Console.ReadLine();

        Users.CreateUser(userName, userPass);
    }

    public CreateUserCommand() : base(name, description) {}
}