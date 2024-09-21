using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace RimWorld_Mod_Structure_Builder
{
    public static class Utils
    {
        /// <summary>
        /// Returns the image size in MB
        /// </summary>
        /// <param name="image">Set of bytes</param>
        /// <returns>The image size in MB</returns>
        public static float ImageSize(this byte[] image) => (float)image.Length / 1024 / 1024;

        
        /// <summary>
        /// Adds the element with the given name and value to the XElement
        /// if the value is not null or empty.
        /// </summary>
        /// <param name="element">The XElement to add to</param>
        /// <param name="name">The name of the element to add</param>
        /// <param name="value">The value of the element to add</param>
        public static void AddIfNotNullOrEmpty(this XElement element, string name, string value)
        {
            if(string.IsNullOrEmpty(value))
                return;

            element.Add(name, value);
        }
        
        /// <summary>
        /// Returns the path to the RimWorld mods folder.
        /// If the default mods folder is not found, the user is prompted to enter the path.
        /// </summary>
        /// <returns>The path to the RimWorld mods folder</returns>
        public static string GetRimWorldModFolder()
        {
            var modFolder = "";

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                modFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
                    "Steam", "steamapps", "common", "RimWorld", "Mods");
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                modFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    "Library", "Application Support", "Steam", "steamapps", "common", "RimWorld", "RimWorldMac.app", "Mods");
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                modFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    ".steam", "steam", "steamapps", "common", "RimWorld", "Mods");
            }

            if (!Directory.Exists(modFolder))
            {
                Console.WriteLine("Default RimWorld mod folder not found.");
                modFolder = GetSingleInput("Please enter the path to your RimWorld mod folder:");
                if (!Directory.Exists(modFolder))
                {
                    Console.WriteLine("The specified folder does not exist.");
                    return null;
                }
            }

            return modFolder;
        }

        /// <summary>
        /// Asks the user for a single input.
        /// If the input is required, the user is prompted until a non-empty value is entered.
        /// </summary>
        /// <param name="prompt">The prompt to display</param>
        /// <param name="required">Whether the input is required</param>
        /// <returns>The input entered by the user</returns>
        public static string GetSingleInput(string prompt, bool required = true)
        {
            Logging.Debug($"{prompt} {(required ? "" : "(Optional)")}");
            var input = Console.ReadLine()?.Trim();

            while (string.IsNullOrEmpty(input) && required)
            {
                Logging.Error("Please enter a value! (Required)");
                input = Console.ReadLine()?.Trim();
            }
            Logging.Log("");

            return input;
        }

        /// <summary>
        /// Asks the user for multiple inputs.
        /// The user is prompted to enter values until an empty string is entered.
        /// </summary>
        /// <param name="prompt">The prompt to display</param>
        /// <returns>A list of all the input entered by the user</returns>
        public static List<string> GetMultipleInputs(string prompt)
        {
            var inputs = new List<string>();

            Logging.Debug(prompt);
            string input;
            do
            {
                input = Console.ReadLine()?.Trim();
                if (!string.IsNullOrEmpty(input))
                {
                    inputs.Add(input);
                }
            } while (!string.IsNullOrEmpty(input));
            Logging.Log("");

            return inputs;
        }

        /// <summary>
        /// Asks the user a yes/no question.
        /// The user is prompted until a valid 'y' or 'n' is entered.
        /// </summary>
        /// <param name="prompt">The prompt to display</param>
        /// <returns>True if the user entered 'y', false if the user entered 'n'</returns>
        public static bool GetYesNoInput(string prompt)
        {
            while (true)
            {
                Logging.Debug($"{prompt} (y/n)");
                var input = Console.ReadLine().Trim().ToLower();
                if (input == "y") return true;
                if (input == "n") return false;
                Logging.Error("Invalid input. Please enter 'y' or 'n'.");
            }
        }

        public static void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}