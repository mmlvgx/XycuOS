namespace XycuOS;

public class Users
{
    public static User? CurrentUser;
    public static List<User> UsersList = new();
    public static Dictionary<string, User> UsersDictionary = new();

    public static User? CreateUser(string? userName, string? userPass)
    {
        if (userName is null || userPass is null) return null;

        // Check if the given User Name is in Users Dictionary
        if (UsersDictionary.ContainsKey(userName)) return null;

        var user = new User(userName, userPass);

        UsersList.Add(user);
        UsersDictionary.Add(user.Name, user);

        return user;
    }

    public static void DeleteUser(string? userName, string? userPass)
    {
        if (userName is null || userPass is null) return;

        // Check if the given User Name is in Users Dictionary
        if (UsersDictionary.ContainsKey(userName) is false) return;

        // Check if the given User Pass is equals actually User Pass
        var user = UsersDictionary[userName];
        var pass = user.Pass;

        if (pass.Equals(userPass) is false) return;

        UsersList.Remove(user);
        UsersDictionary.Remove(user.Name);
    }

    public static void ChangeCurrentUser(string? userName, string? userPass)
    {
        if (userName is null || userPass is null) return;

        // Check if the given User Name is in Users Dictionary
        if (UsersDictionary.ContainsKey(userName) is false) return;

        // Check if the given User Pass is equals actually User Pass
        var user = UsersDictionary[userName];
        var pass = user.Pass;

        if (pass.Equals(userPass) is false) return;

        CurrentUser = user;
    }
}