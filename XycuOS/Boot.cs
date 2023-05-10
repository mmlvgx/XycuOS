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
        while (true)
        {
            Console.Write("XycuOS >>");
            var line = Console.ReadLine();

            /*
                Check if the string is not null or empty
            */
            if (!string.IsNullOrEmpty(line))
            {
                /*
                    Iterating the list to find the command
                */
                foreach (Command command in Globals.commands)
                {
                    /* 
                        Running a command
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