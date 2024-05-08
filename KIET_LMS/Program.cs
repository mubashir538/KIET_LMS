using KIET_LMS.Program_manager;
using KIET_LMS.Teachers;
using System.Diagnostics;

namespace KIET_LMS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (PriorProcess() != null)
            {
                MessageBox.Show("Application is Already Running!");

                return;
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Welcome());
        }

        public static Process PriorProcess()
        {
            Process currentProcess = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(currentProcess.ProcessName);
            foreach (Process process in processes)
            {
                if ((process.Id != currentProcess.Id) && (process.MainModule.FileName == currentProcess.MainModule.FileName))
                {
                    return process;

                }
            }

            return null;
        }
    }
}