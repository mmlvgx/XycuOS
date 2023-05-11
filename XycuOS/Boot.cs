namespace XycuOS;

public class Boot
{
    public static void BeforeStart()
    {
        Console.Title = "XycuOS";
        // Clears the console buffer
        Console.Clear();

        var banner =
        """
        __  __                 ___  ____ 
        \ \/ /   _  ___ _   _ / _ \/ ___|
         \  / | | |/ __| | | | | | \___ \
         /  \ |_| | (__| |_| | |_| |___) |
        /_/\_\__, |\___|\__,_|\___/|____/
             |___/                        
        """;

        Console.WriteLine(banner);
    }

    public static void AfterStart()
    {
        var isReady = false;

        while (isReady is false)
        {
            Console.Write("User name: ");
            var userName = Standarts.ReadLine(isSecure:false);

            Console.Write("User pass: ");
            var userPass = Standarts.ReadLine(isSecure:true);

            var user = Users.CreateUser(userName, userPass);

            // Check if the new User is not null
            // (Feature of Users CreateUser method)
            if (user is null) continue;

            Users.ChangeCurrentUser(user.Name, user.Pass);

            // Exit the loop
            isReady = true;
        }

        Console.Clear();

        while (true)
        {
            var currentUser = Users.CurrentUser;

            if (currentUser is null) return;

            Console.Write($"{currentUser.Name} XycuOS >>");
            var line = Console.ReadLine();

            if (line is null) continue;

            // Check if the line is in Commands Dictionary
            var isInCommandDictionary = Commands.CommandsDictionary.ContainsKey(line);

            if (isInCommandDictionary is false) continue;

            // Finally run the command
            Commands.CommandsDictionary[line].Run();
        }
    }

    public static void Start()
    {
        BeforeStart();
        // Not required yet
        AfterStart();
    }
}