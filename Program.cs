using ClickableTransparentOverlay;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using GameCheatTemplate;

namespace GameCheatTemplate
{
    public class Program : Overlay
    {
        private CheatLogic cheatLogic;
        public static bool render = true;

        public Program()
        {
            cheatLogic = new CheatLogic();
        }

        protected override void Render()
        {
            if (render) { cheatLogic.RenderUI(); }
        }

        // Hide Console
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;

        public static void Main(string[] args)
        {
            // Hide Console
            IntPtr handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);

            Program program = new Program();
            program.Start().Wait();

            Thread hackThread = new Thread(program.cheatLogic.RunHackLogic) { IsBackground = true };
            hackThread.Start();
        }
    }
}