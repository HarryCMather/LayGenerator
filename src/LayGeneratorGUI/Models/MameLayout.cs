using System.Xml.Serialization;

namespace LayGeneratorGUI.Models;

[XmlRoot("mamelayout")]
internal class MameLayout
{
    [XmlAttribute("comment")]
    public string Comment { get; set; }

    [XmlAttribute("version")]
    public string Version { get; set; }

    [XmlAttribute("elements")]
    public List<Element> Elements { get; set; } = new();

    [XmlAttribute("views")]
    public List<View> Views { get; set; } = new();
}
