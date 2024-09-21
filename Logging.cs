using System;

namespace RimWorld_Mod_Structure_Builder
{
    public static class Logging
    {
        public static void Log(string message)
        {
            Console.WriteLine(message);
        }
        
        public static void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"INFO: {message}");
            Console.ResetColor();
        }
        
        public static void Debug(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"DEBUG: {message}");
            Console.ResetColor();
        }
        
        public static void Success(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"SUCCESS: {message}");
            Console.ResetColor();
        }
        
        public static void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"WARNING: {message}");
            Console.ResetColor(); 
        }
        
        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERROR: {message}");
            Console.ResetColor();
        }
    }
}