namespace XycuOS;

public class Users
{
    public static User? currentUser;
    public static List<User> users = new();

    public static User NewUser(string userName, string passName)
    {
        /*
            Initializing a new User
        */
        User user = new User(userName, passName);
        /*
            Adding new User to Users list
        */
        users.Add(user);

        return user;
    }

    public static void ChangeCurrentUser(User user)
    {
        currentUser = user;
    }
}