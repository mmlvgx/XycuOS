namespace XycuOS;

public class Standarts
{
    public static string ReadLine(bool isSecure)
    {
        var input = "";

        while (true)
        {
            var inputLenght = input.Length;

            // The pressed key is intercepted and
            // not displayed in the console window
            var keyInfo = Console.ReadKey(intercept:true);

            var isEscape = keyInfo.Key.Equals(ConsoleKey.Escape);
            var isEnter = keyInfo.Key.Equals(ConsoleKey.Enter);
            var isBackspace = keyInfo.Key.Equals(ConsoleKey.Backspace);

            if (isEscape || isEnter) 
            {
                // Starts a new line
                Console.Write(System.Environment.NewLine);

                break;
            }
            if (isBackspace)
            {
                if (inputLenght <= 0) continue;

                var lastCharacterPosition = inputLenght - 1;
                input = input.Remove(lastCharacterPosition, 1);

                // Backspace escape code
                Console.Write("\b \b");

                continue;
            }

            char keyChar = keyInfo.KeyChar;

            input += keyChar;

            if (isSecure is true) Console.Write("*");
            if (isSecure is false) Console.Write(keyChar);
        }

        return input;
    }
}