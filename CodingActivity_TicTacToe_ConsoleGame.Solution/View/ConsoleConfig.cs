﻿using System;

namespace CodingActivity_TicTacToe_ConsoleGame
{
    /// <summary>
    /// Struct to store the initial settings for the console window
    /// </summary>
    public struct ConsoleConfig
    {
        public const int windowWidth = 100;
        public const int windowHeight = 35;

        public const int windowLeft = 20;
        public const int windowTop = 20;

        public const string headerText = "- set header text -";

        public const ConsoleColor headerBackgroundColor = ConsoleColor.White;
        public const ConsoleColor headerForegroundColor = ConsoleColor.Red;

        public const ConsoleColor bodyBackgroundColor = ConsoleColor.Black;
        public const ConsoleColor bodyForegroundColor = ConsoleColor.White;

        public const string windowTitle = " - set window title - ";

        public const int displayHorizontalMargin = 3;
    }
}
