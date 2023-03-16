using System.Reflection;

[assembly: AssemblyVersion("1.0.1.*")]

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
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1(version));
    }
}
