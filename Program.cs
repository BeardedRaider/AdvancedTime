using System; // Namespace that contains fundamental classes like Console and DateTime
using System.Threading; // Namespace that contains the Thread class for pausing execution

class Program
{
    static void Main()
    {
        // Get the current time when the application starts
        DateTime startTime = DateTime.Now;

        // Format the start time as HH:MM:SS
        string startTimeString = startTime.ToString("HH:mm:ss");

        // Display the start time of the application
        Console.WriteLine("The time of starting this application was: " + startTimeString);

        Console.Write("The Current Live time is: ");
        
        // Set the console input mode to not wait for Enter key
        Console.TreatControlCAsInput = true;
        
        // Infinite loop for live time display
        while (!Console.KeyAvailable)
        {
            // Get the current time
            DateTime now = DateTime.Now;

            // Format the current time as HH:MM:SS
            string liveTimeString = now.ToString("HH:mm:ss");

            // Calculate the cursor position to ensure the live time is displayed correctly
            int cursorLeft = "The Current Live time is: ".Length; // Length of the static text
            int cursorTop = Console.CursorTop; // Get the current row position

            // Move the cursor to the position where the live time should be displayed
            Console.SetCursorPosition(cursorLeft, cursorTop);

            // Display the live time and add extra spaces to clear previous characters
            Console.Write(liveTimeString + "  " + "Double Press any key to exit...");

            // Pause the program for 1 second before updating the time again
            Thread.Sleep(1000);
        }

        // Clear the key press from the input buffer
        Console.ReadKey(true);
        
        // Display the exit message and wait for any key to exit
        Console.Write("One more key press to exit...");
        Console.ReadKey();
    }
}
