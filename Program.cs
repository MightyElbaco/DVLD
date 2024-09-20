using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;
//Hello World
namespace DVLD
{
    internal static class Program
    {
        // Constants for process access rights
        const uint PROCESS_QUERY_INFORMATION = 0x0400;
        const uint PROCESS_VM_READ = 0x0010;
        const uint PROCESS_TERMINATE = 0x0001;

        // Maximum path length for module name
        const int MAX_PATH = 260;

        // Importing necessary functions from psapi.dll and kernel32.dll
        [DllImport("psapi.dll", SetLastError = true)]
        static extern bool EnumProcesses(
            [Out] uint[] lpidProcess,
            uint cb,
            out uint lpcbNeeded);

        [DllImport("psapi.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern uint GetModuleBaseName(
            IntPtr hProcess,
            IntPtr hModule,
            [Out] StringBuilder lpBaseName,
            int nSize);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr OpenProcess(
            uint dwDesiredAccess,
            bool bInheritHandle,
            uint dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool TerminateProcess(
            IntPtr hProcess,
            uint uExitCode);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool CloseHandle(IntPtr hObject);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            //Application.Run(new TestingForm());


            //Use Win32 APIs via PInvoke to locate and terminate instances of DVLD.exe
            //This is not the best practice and too risky but I count on it for now till I learn a better method
            try
            {
                // Step 1: Enumerate all processes
                uint[] processIds = new uint[1024];
                uint bytesReturned;

                if (!EnumProcesses(processIds, (uint)(processIds.Length * sizeof(uint)), out bytesReturned))
                {
                    Console.WriteLine("Failed to enumerate processes.");
                    return;
                }

                int processCount = (int)(bytesReturned / sizeof(uint));
                Console.WriteLine($"Total Processes Found: {processCount}");

                bool dvldFound = false;

                // Step 2: Iterate through each process to find DVLD.exe
                for (int i = 0; i < processCount; i++)
                {
                    uint pid = processIds[i];
                    if (pid == 0)
                        continue; // Skip system idle process

                    // Open the process with QUERY_INFORMATION and VM_READ to get module information
                    IntPtr hProcess = OpenProcess(PROCESS_QUERY_INFORMATION | PROCESS_VM_READ, false, pid);
                    if (hProcess == IntPtr.Zero)
                    {
                        // Unable to open process (might not have permissions)
                        continue;
                    }

                    try
                    {
                        StringBuilder processName = new StringBuilder(MAX_PATH);
                        uint size = GetModuleBaseName(hProcess, IntPtr.Zero, processName, processName.Capacity);
                        if (size > 0)
                        {
                            string exeName = processName.ToString();

                            // Check if the process name matches "DVLD.exe" (case-insensitive)
                            if (exeName.Equals("DVLD.exe", StringComparison.OrdinalIgnoreCase))
                            {
                                dvldFound = true;
                                Console.WriteLine($"Found DVLD.exe with PID: {pid}");

                                // Step 3: Terminate the process
                                TerminateSpecificProcess(pid);
                            }
                        }
                    }
                    finally
                    {
                        // Always close the handle
                        CloseHandle(hProcess);
                    }
                }

                if (!dvldFound)
                {
                    Console.WriteLine("No instances of DVLD.exe were found running.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            Console.WriteLine("Operation completed. Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// Terminates a process given its Process ID (PID).
        /// </summary>
        /// <param name="pid">Process ID of the target process.</param>
        static void TerminateSpecificProcess(uint pid)
        {
            // Open the process with TERMINATE access
            IntPtr hProcess = OpenProcess(PROCESS_TERMINATE, false, pid);
            if (hProcess == IntPtr.Zero)
            {
                Console.WriteLine($"Failed to open process {pid} for termination. Error: {Marshal.GetLastWin32Error()}");
                return;
            }

            try
            {
                // Attempt to terminate the process
                if (TerminateProcess(hProcess, 1))
                {
                    Console.WriteLine($"Successfully terminated DVLD.exe with PID: {pid}");
                }
                else
                {
                    Console.WriteLine($"Failed to terminate process {pid}. Error: {Marshal.GetLastWin32Error()}");
                }
            }
            finally
            {
                // Always close the handle
                CloseHandle(hProcess);
            }
        }
    }
}