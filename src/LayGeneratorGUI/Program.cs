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
        string version = Assembly.GetExecutingAssembly().GetName().Version?.ToString();
        version ??= "Development";
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1(version));
    }
}
