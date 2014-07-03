using System;

namespace HelloRealWorld.Common
{
    /// <summary>
    /// Provides methods for writing to the console.
    /// </summary>
    public static class ConsoleManager
    {
        /// <summary>
        /// Writes the welcome message to the console.
        /// </summary>
        public static void WriteWelcomeMessage()
        {
            Console.WriteLine(ContentManager.WelcomeMessage);
        }

        /// <summary>
        /// Reads a line from the console in order to pause execution.
        /// </summary>
        public static void Pause()
        {
            Console.ReadLine();
        }
    }
}
