using System.Reflection;
using System.Runtime;
using System.Runtime.InteropServices;
using static System.Console;

WriteLine($"Machine Name: {Environment.MachineName}");
WriteLine($"User Domain Name: {Environment.UserDomainName}");
WriteLine($"User Name: {Environment.UserName}");
WriteLine($"User Interactive Mode: {Environment.UserInteractive}");

WriteLine();

WriteLine($"CLR Version: {Environment.Version}");
WriteLine($"Framework Description: {RuntimeInformation.FrameworkDescription}");
WriteLine($"OS Architecture: {RuntimeInformation.OSArchitecture}");
WriteLine($"Is Server GC: {GCSettings.IsServerGC}");

// Get Assembly information for the executing assembly
var assembly = Assembly.GetExecutingAssembly();
// Get the .NET version used by the application
WriteLine($".NET Version (from Assembly): {assembly.GetCustomAttribute<System.Runtime.Versioning.TargetFrameworkAttribute>()?.FrameworkName}");

WriteLine();

WriteLine($"OS Version: {Environment.OSVersion}");
WriteLine($"64 bit OS: {Environment.Is64BitOperatingSystem}");
WriteLine($"64 bit process: {Environment.Is64BitProcess}");
WriteLine($"Process Architecture: {RuntimeInformation.ProcessArchitecture}");
WriteLine($"OS Description: {RuntimeInformation.OSDescription}");
WriteLine($"Number of processors: {Environment.ProcessorCount}");
WriteLine($"System Uptime: {Environment.TickCount64} milliseconds");
WriteLine($"Current Managed Thread ID: {Environment.CurrentManagedThreadId}");
WriteLine($"System Page Size: {Environment.SystemPageSize} bytes");
WriteLine($"Working Set: {Environment.WorkingSet} bytes"); // Working Set - Physical memory usage

WriteLine();

WriteLine($"System Directory: {Environment.SystemDirectory}");
WriteLine($"Fonts Directory: {Environment.GetFolderPath(Environment.SpecialFolder.Fonts)}");
WriteLine($"Current Directory: {Environment.CurrentDirectory}");
WriteLine($"Desktop Directory: {Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}");
WriteLine($"My Documents Directory: {Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}");
WriteLine($"My Pictures Directory: {Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}");
WriteLine($"My Music Directory: {Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)}");
WriteLine($"My Videos Directory: {Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)}");
WriteLine($"Program Files Directory: {Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}");
WriteLine($"Startup Directory: {Environment.GetFolderPath(Environment.SpecialFolder.Startup)}");

WriteLine();

var drives = Environment.GetLogicalDrives();
WriteLine($"Drives: {drives.Length}");
foreach (var drive in drives)
{
    WriteLine($"\t-> Drive: {drive}");
}

WriteLine();

WriteLine($"Var[Path]: {Environment.GetEnvironmentVariable("Path")}");

WriteLine();

var envirmomentVariables = Environment.GetEnvironmentVariables();
WriteLine($"Environment Variables: {envirmomentVariables.Count}");
foreach (var env in envirmomentVariables)
{
    WriteLine($"\tVAR -> {env}");
}

WriteLine();

WriteLine("Detailed Drive Information:");
foreach (var drive in DriveInfo.GetDrives())
{
    try
    {
        WriteLine($"\tDrive: {drive.Name}");
        WriteLine($"\t\tDrive Type: {drive.DriveType}");
        if (drive.IsReady)
        {
            WriteLine($"\t\tVolume Label: {drive.VolumeLabel}");
            WriteLine($"\t\tDrive Format: {drive.DriveFormat}");
            WriteLine($"\t\tAvailable Free Space: {drive.AvailableFreeSpace} bytes");
            WriteLine($"\t\tTotal Free Space: {drive.TotalFreeSpace} bytes");
            WriteLine($"\t\tTotal Size: {drive.TotalSize} bytes");
        }
    }
    catch (System.Exception ex)
    {
        WriteLine($"\t\tError retrieving information for drive {drive.Name}: {ex.Message}");
    }
}
