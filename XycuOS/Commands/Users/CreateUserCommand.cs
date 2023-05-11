namespace XycuOS;

public class CreateUserCommand : Command
{
    public static string name = "CreateUser";
    public static string description = "Creates a user";

    public override void Run()
    {
        Console.Write("User name: ");
        var userName = Standarts.ReadLine(isSecure:false);

        Console.Write("User pass: ");
        var userPass = Standarts.ReadLine(isSecure:true);

        Users.CreateUser(userName, userPass);
    }

    public CreateUserCommand() : base(name, description) {}
}