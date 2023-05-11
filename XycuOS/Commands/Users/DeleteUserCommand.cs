namespace XycuOS;

public class DeleteUserCommand : Command
{
    public static string name = "DeleteUser";
    public static string description = "Deletes a user";

    public override void Run()
    {
        Console.Write("User name: ");
        var userName = Standarts.ReadLine(isSecure:false);

        Console.Write("User pass: ");
        var userPass = Standarts.ReadLine(isSecure:true);

        Users.DeleteUser(userName, userPass);
    }

    public DeleteUserCommand() : base(name, description) {}
}