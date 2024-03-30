using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string[] processNames = { "OculusClient", "OVRRedir", "OVRServer_x64", "OVRServiceLauncher" };

        foreach (string processName in processNames)
        {
            Process[] processes = Process.GetProcessesByName(processName);

            if (processes.Length > 0)
            {
                foreach (Process process in processes)
                {
                    Console.WriteLine($"Terminating process: {process.ProcessName} (ID: {process.Id})");
                    process.Kill();
                }
            }
            else
            {
                Console.WriteLine($"No process with the name '{processName}' found.");
            }
        }

        Console.WriteLine("");
        Console.ReadLine();
    }
}
