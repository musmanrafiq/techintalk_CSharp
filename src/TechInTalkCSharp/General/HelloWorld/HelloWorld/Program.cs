﻿using System.Runtime.InteropServices;

namespace HelloWorld
{

    internal class Program
    {
        const int SWP_NOZORDER = 0x4;
        const int SWP_NOACTIVATE = 0x10;

        [DllImport("kernel32")]
        static extern IntPtr GetConsoleWindow();


        [DllImport("user32")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter,
            int x, int y, int cx, int cy, int flags);

        static void Main(string[] args)
        {
            Console.WindowWidth = 0;
            Console.WindowHeight = 0;
            Console.BufferWidth = 0;
            Console.BufferHeight = 0;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            //var screen = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            //var width = screen.Width;
            //var height = screen.Height;

            SetWindowPosition(100, 0, 500, 500);
            Console.Title = "My Title";
            Console.WriteLine("");
            Console.Write(" Press any key to close this window ...");

            Console.ReadKey();
        }


        /// <summary>
        /// Sets the console window location and size in pixels
        /// </summary>
        public static void SetWindowPosition(int x, int y, int width, int height)
        {
            SetWindowPos(Handle, IntPtr.Zero, x, y, width, height, SWP_NOZORDER | SWP_NOACTIVATE);
        }

        public static IntPtr Handle
        {
            get
            {
                //Initialize();
                return GetConsoleWindow();
            }
        }

    }
}

