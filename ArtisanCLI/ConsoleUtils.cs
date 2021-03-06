﻿using System;

namespace ConsoleHints
{
    internal static class ConsoleUtils
    {
        public const string Prompt = "Artisan> ";
        public static void WriteLine(string line, ConsoleColor color)
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(line);
            Console.ForegroundColor = currentColor;
        }

        public static void Write(string line, ConsoleColor color)
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(line);
            Console.ForegroundColor = currentColor;
        }

        public static void WritePrompt()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Prompt);
            Console.ResetColor();
        }
    }
}
