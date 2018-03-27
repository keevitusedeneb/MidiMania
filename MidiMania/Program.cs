using System;

namespace MidiMania
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static string filePath;
        [STAThread]
        static void Main(string[] args)
        {
            if (args[0] != null)
            {
                filePath = args[0];
                using (var game = new Game1())
                    game.Run();
            }

            
        }
    }
}
