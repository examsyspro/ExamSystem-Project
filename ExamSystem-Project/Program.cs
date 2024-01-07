

using ExamSystem_Project.Forms;

namespace ExamSystem_Project
{
    internal static class Program
    {
        [System.Runtime.InteropServices.DllImport("Shcore.dll")]
        private static extern int SetProcessDpiAwareness(int PROCESS_DPI_AWARENESS);

        private const int PROCESS_DPI_UNAWARE = 0;
        private const int PROCESS_SYSTEM_DPI_AWARE = 1;
        private const int PROCESS_PER_MONITOR_DPI_AWARE = 2;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            SetProcessDpiAwareness(PROCESS_PER_MONITOR_DPI_AWARE);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            Application.Run(new BuildExamForm());
        }
    }
}