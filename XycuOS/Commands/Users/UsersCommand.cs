namespace XycuOS;

public class UsersCommand : Command
{
    public static string name = "Users";
    public static string description =
        "Displays information about all available users";

    public override void Run()
    {
        foreach (User user in Users.UsersList)
        {
            string information = $"・ {user.Name}";

            Console.WriteLine(information);
        }
    }

    public UsersCommand() : base(name, description) {}
}