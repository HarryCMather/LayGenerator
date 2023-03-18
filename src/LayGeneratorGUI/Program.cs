using System.Reflection;

namespace LayGeneratorGUI;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        string version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? " Development Build";

        if (version.Count(character => character == '.') == 3)
        {
            version = version[..^2];
        }

        version = version == "1.0.0" ? " Development Build" : $@" V-{version}"; // Remove last two characters, as the Version that's being read is not adhering to the samver versioning standard.

        ApplicationConfiguration.Initialize();
        Application.Run(new Form1(version));
    }
}
