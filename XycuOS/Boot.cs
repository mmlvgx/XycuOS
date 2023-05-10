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
            Console.Write("User name: ");
            var userName = Console.ReadLine();

            Console.Write("User pass: ");
            var userPass = Console.ReadLine();

            if (userName is not null && userPass is not null)
            {
                Users.ChangeCurrentUser(new User(userName, userPass));
                /*
                    Exit the loop
                */
                isReady = true;
            }
        }
        /*
            Clears the console buffer
        */
        Console.Clear();

        var currentUser = Users.currentUser;

        while (true)
        {
            if (currentUser is not null)
                Console.Write($"{currentUser.Name} XycuOS >>");

            var line = Console.ReadLine();
            /*
                Check if the string is not null or empty
            */
            if (line is not null)
            {
                /*
                    Iterate the list to find the command
                */
                foreach (Command command in Commands.commands)
                {
                    /* 
                        Run a command
                    */
                    if (line.StartsWith(command.Name))
                    {
                        command.Run();
                    }
                }
            }
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