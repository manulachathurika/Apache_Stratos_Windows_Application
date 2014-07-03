using HelloRealWorld.Common;

namespace HelloRealWorld.Console
{
    /// <summary>
    /// Container for application entry point.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main entry point for the application.
        /// </summary>
        private static void Main()
        {
            ConsoleManager.WriteWelcomeMessage();
            ConsoleManager.Pause();
        }
    }
}
