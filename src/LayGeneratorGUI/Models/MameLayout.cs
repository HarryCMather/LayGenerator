namespace LayGeneratorGUI.Models;

public class MameLayout
{
    public string Comment { get; set; }

    public string Version { get; set; }

    public List<Element> Elements { get; set; } = new();

    public List<View> Views { get; set; } = new();
}
