namespace XycuOS;

public class DeleteUserCommand : Command
{
    public static string name = "DeleteUser";
    public static string description = "Deletes a user";

    public override void Run()
    {
        /*
            Get a User Name and User Pass from Standart Input Stream
        */
        Console.Write("User name: ");
        var userName = Console.ReadLine();

        Console.Write("User pass: ");
        var userPass = Console.ReadLine();

        Users.DeleteUser(userName, userPass);
    }

    public DeleteUserCommand() : base(name, description) {}
}