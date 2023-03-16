namespace LayGeneratorGUI.Models;

public class View
{
    public string Name { get; set; }

    public string Comment { get; set; }

    public Screen Screen { get; set; }

    public List<Bezel> Bezels { get; set; } = new();
}
