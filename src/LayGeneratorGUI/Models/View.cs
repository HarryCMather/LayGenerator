using System.Xml.Serialization;

namespace LayGeneratorGUI.Models;

public class View
{
    public string Name { get; set; }
    public string Comment { get; set; }

    [XmlElement("screen")]
    public Screen Screen { get; set; }

    public List<Bezel> Bezels { get; set; } = new(); //this needs to be <bezels> as this is already being removed in XmlExtensions
}
