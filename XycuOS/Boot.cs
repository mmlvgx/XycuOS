namespace XycuOS;

public class Boot
{
    public static void BeforeStart()
    {
        Console.Title = "XycuOS";
        // Clears the console buffer
        Console.Clear();

        var bannerLines = new List<string>()
        {
            " █████ █████                                   ███████     █████████ ",
            "░░███ ░░███                                  ███░░░░░███  ███░░░░░███",
            " ░░███ ███   █████ ████  ██████  █████ ████ ███     ░░███░███    ░░░ ",
            "  ░░█████   ░░███ ░███  ███░░███░░███ ░███ ░███      ░███░░█████████ ",
            "   ███░███   ░███ ░███ ░███ ░░░  ░███ ░███ ░███      ░███ ░░░░░░░░███",
            "  ███ ░░███  ░███ ░███ ░███  ███ ░███ ░███ ░░███     ███  ███    ░███",
            " █████ █████ ░░███████ ░░██████  ░░████████ ░░░███████░  ░░█████████ ",
            "░░░░░ ░░░░░   ░░░░░███  ░░░░░░    ░░░░░░░░    ░░░░░░░     ░░░░░░░░░  ",
            "              ███ ░███                                               ",
            "             ░░██████                                                ",
            "              ░░░░░░                                                 ",
        };

        foreach(string bannerLine in bannerLines)
            Console.WriteLine(bannerLine);
    }

    public static void AfterStart()
    {
        var isReady = false;

        while (isReady is false)
        {
            /*
                Get a User Name and User Pass from Standart Input Stream
            */
            Console.Write("User name: ");
            var userName = Console.ReadLine();

            Console.Write("User pass: ");
            var userPass = Console.ReadLine();
            /*
                Creating a new User
            */
            var user = Users.CreateUser(userName, userPass);
            /*
                Check if the new User is not null
                (Feature of Users CreateUser method)
            */
            if (user is null) continue;
            /*
                Change current user to a new
            */
            Users.ChangeCurrentUser(user.Name, user.Pass);
            /*
                Exit the loop
            */
            isReady = true;
        }
        /*
            Clears the console buffer
        */
        Console.Clear();

        while (true)
        {
            var currentUser = Users.CurrentUser;
            /*
                Check if a current User is null
            */
            if (currentUser is null) return;

            Console.Write($"{currentUser.Name} XycuOS >>");
            var line = Console.ReadLine();
            /*
                Check if the string is null
            */
            if (line is null) continue;
            /*
                Check if the line is in Commands Dictionary
            */
            var isInCommandDictionary = Commands.CommandsDictionary.ContainsKey(line);
            if (isInCommandDictionary is false) continue;
            /*
                Finally run the command
            */
            Commands.CommandsDictionary[line].Run();
        }
    }

    public static void Start()
    {
        BeforeStart();
        /*
            Not required yet
        */
        AfterStart();
    }
}