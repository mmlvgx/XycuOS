namespace XycuOS;

public class Users
{
    public static User? CurrentUser;
    public static List<User> UsersList = new();
    public static Dictionary<string, User> UsersDictionary = new();

    public static User? CreateUser(string? userName, string? userPass)
    {
        /*
            Check if the given User Name or User Pass is null
        */
        if (userName is null || userPass is null) return null;
        /*
            Check if the given User Name is in Users Dictionary
        */
        if (UsersDictionary.ContainsKey(userName)) return null;
        /*
            Initializing a new User
        */
        var user = new User(userName, userPass);
        /*
            Adding a new User to Dictionary
        */
        UsersList.Add(user);
        UsersDictionary.Add(user.Name, user);

        return user;
    }

    public static void DeleteUser(string? userName, string? userPass)
    {
        /*
            Check if the given User Name or User Pass is null
        */
        if (userName is null || userPass is null) return;
        /*
            Check if the given User Name is in Users Dictionary
        */
        if (UsersDictionary.ContainsKey(userName) is false) return;
        /*
            Check if the given User Pass is equals actually User Pass
        */
        var user = UsersDictionary[userName];
        var pass = user.Pass;

        if (pass.Equals(userPass) is false) return;
        /*
            Finally removing a user
        */
        UsersList.Remove(user);
        UsersDictionary.Remove(user.Name);
    }

    public static void ChangeCurrentUser(string? userName, string? userPass)
    {
        /*
            Check if the given User Name or User Pass is null
        */
        if (userName is null || userPass is null) return;
        /*
            Check if the given User Name is in Users Dictionary
        */
        if (UsersDictionary.ContainsKey(userName) is false) return;
        /*
            Check if the given User Pass is equals actually User Pass
        */
        var user = UsersDictionary[userName];
        var pass = user.Pass;

        if (pass.Equals(userPass) is false) return;
        /*
            Finally changing current User
        */
        CurrentUser = user;
    }
}