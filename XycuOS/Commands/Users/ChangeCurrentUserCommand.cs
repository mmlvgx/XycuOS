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
        var userName = Standarts.ReadLine(isSecure:false);

        Console.Write("User pass: ");
        var userPass = Standarts.ReadLine(isSecure:true);

        Users.ChangeCurrentUser(userName, userPass);
    }

    public ChangeCurrentUserCommand() : base(name, description) {}
}