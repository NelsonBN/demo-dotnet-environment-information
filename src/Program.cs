using static System.Console;

WriteLine($"Machine Name: {Environment.MachineName}");
WriteLine($"User Domain Name: {Environment.UserDomainName}");

WriteLine();

WriteLine($"64 bit OS: {Environment.Is64BitOperatingSystem}");
WriteLine($"64 bit process: {Environment.Is64BitProcess}");
WriteLine($"Number of processors: {Environment.ProcessorCount}");

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
